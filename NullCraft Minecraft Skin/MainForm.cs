using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NullCraft_Minecraft_Skin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //为了节省大小，请自行使用Nuget安装 Newtonsoft.Json 包
            //本版本为测试版，无UI设计
            //本程序由快辰制作，灵工艺软件工作室版权所有
            //免费开源，禁止商用
        }
        public static string HttpGet(string Url, string postDataStr)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | (SecurityProtocolType)0x300 | (SecurityProtocolType)0xC00; //SSL/TLS必须
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch
            {
                return "";
            }
        }
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        private void Button_GetSkin_Click(object sender, EventArgs e)
        {
            if (TextBox_ID.Text != "")
            {
                if (RadioButton_Mojang.Checked == true)
                {
                    Thread ThreadMojang = new Thread(new ThreadStart(MojangAPI));
                    ThreadMojang.IsBackground = true;
                    ThreadMojang.Start();
                }
                if (RadioButton_Crafatar.Checked == true)
                {
                    Thread ThreadCrafatar = new Thread(new ThreadStart(CrafatarAPI));
                    ThreadCrafatar.IsBackground = true;
                    ThreadCrafatar.Start();
                }
            }
            else
            {
                MessageBox.Show("不输入ID查谁哦?", "玩呢?", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            
        }
        public void MojangAPI()
        {
            string mojang_json = HttpGet("https://api.mojang.com/users/profiles/minecraft/" + TextBox_ID.Text, "");
            JObject get_uuid = (JObject)JsonConvert.DeserializeObject(mojang_json);
            mojang_json = HttpGet("https://sessionserver.mojang.com/session/minecraft/profile/" + get_uuid["id"].ToString(), "");
            JObject get_value = (JObject)JsonConvert.DeserializeObject(mojang_json);
            try
            {
                mojang_json = DecodeBase64("utf-8", get_value["properties"][0]["value"].ToString());
                JObject get_skin_url = (JObject)JsonConvert.DeserializeObject(mojang_json);

                PictureBox_Skins.Image = null;
                PictureBox_Skins.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox_Skins.LoadAsync(get_skin_url["textures"]["SKIN"]["url"].ToString());
                
                PictureBox_Capes.Image = null;
                PictureBox_Capes.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox_Capes.LoadAsync(get_skin_url["textures"]["SKIN"]["url"].ToString());
            }
            catch {
                PictureBox_Skins.Image = null;
                PictureBox_Capes.Image = null;
                MessageBox.Show("获取失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void CrafatarAPI()
        {
            string crafatar_json = HttpGet("https://api.mojang.com/users/profiles/minecraft/" + TextBox_ID.Text, "");
            JObject get_uuid = (JObject)JsonConvert.DeserializeObject(crafatar_json);

            PictureBox_Avatars.LoadAsync("https://crafatar.com/avatars/" + get_uuid["id"].ToString());
            PictureBox_Avatars.Image = null;
            PictureBox_Avatars.SizeMode = PictureBoxSizeMode.Zoom;

            PictureBox_Skins.LoadAsync("https://crafatar.com/skins/" + get_uuid["id"].ToString());
            PictureBox_Skins.Image = null;
            PictureBox_Skins.SizeMode = PictureBoxSizeMode.Zoom;

            PictureBox_Capes.LoadAsync("https://crafatar.com/capes/" + get_uuid["id"].ToString());
            PictureBox_Capes.Image = null;
            PictureBox_Capes.SizeMode = PictureBoxSizeMode.Zoom;
        }


    }
}
