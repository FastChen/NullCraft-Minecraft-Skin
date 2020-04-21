namespace NullCraft_Minecraft_Skin
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.Button_GetSkin = new System.Windows.Forms.Button();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButton_Crafatar = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mojang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox_Capes = new System.Windows.Forms.PictureBox();
            this.PictureBox_Skins = new System.Windows.Forms.PictureBox();
            this.PictureBox_Avatars = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Capes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Skins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatars)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "获取结果(头像 - 皮肤 - 披风):";
            // 
            // Button_GetSkin
            // 
            this.Button_GetSkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_GetSkin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_GetSkin.Location = new System.Drawing.Point(319, 36);
            this.Button_GetSkin.Name = "Button_GetSkin";
            this.Button_GetSkin.Size = new System.Drawing.Size(64, 27);
            this.Button_GetSkin.TabIndex = 19;
            this.Button_GetSkin.Text = "获取";
            this.Button_GetSkin.UseVisualStyleBackColor = true;
            this.Button_GetSkin.Click += new System.EventHandler(this.Button_GetSkin_Click);
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TextBox_ID.Location = new System.Drawing.Point(167, 37);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(141, 25);
            this.TextBox_ID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(155, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Minecraft Java ID:";
            // 
            // RadioButton_Crafatar
            // 
            this.RadioButton_Crafatar.AutoSize = true;
            this.RadioButton_Crafatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButton_Crafatar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.RadioButton_Crafatar.Location = new System.Drawing.Point(86, 42);
            this.RadioButton_Crafatar.Name = "RadioButton_Crafatar";
            this.RadioButton_Crafatar.Size = new System.Drawing.Size(73, 21);
            this.RadioButton_Crafatar.TabIndex = 16;
            this.RadioButton_Crafatar.Text = "Crafatar";
            this.RadioButton_Crafatar.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Mojang
            // 
            this.RadioButton_Mojang.AutoSize = true;
            this.RadioButton_Mojang.Checked = true;
            this.RadioButton_Mojang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButton_Mojang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton_Mojang.Location = new System.Drawing.Point(18, 42);
            this.RadioButton_Mojang.Name = "RadioButton_Mojang";
            this.RadioButton_Mojang.Size = new System.Drawing.Size(71, 21);
            this.RadioButton_Mojang.TabIndex = 15;
            this.RadioButton_Mojang.TabStop = true;
            this.RadioButton_Mojang.Text = "Mojang";
            this.RadioButton_Mojang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "选择获取源";
            // 
            // PictureBox_Capes
            // 
            this.PictureBox_Capes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PictureBox_Capes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Capes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Capes.Location = new System.Drawing.Point(253, 102);
            this.PictureBox_Capes.Name = "PictureBox_Capes";
            this.PictureBox_Capes.Size = new System.Drawing.Size(130, 66);
            this.PictureBox_Capes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Capes.TabIndex = 23;
            this.PictureBox_Capes.TabStop = false;
            // 
            // PictureBox_Skins
            // 
            this.PictureBox_Skins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PictureBox_Skins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Skins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Skins.InitialImage = null;
            this.PictureBox_Skins.Location = new System.Drawing.Point(103, 102);
            this.PictureBox_Skins.Name = "PictureBox_Skins";
            this.PictureBox_Skins.Size = new System.Drawing.Size(130, 66);
            this.PictureBox_Skins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Skins.TabIndex = 22;
            this.PictureBox_Skins.TabStop = false;
            // 
            // PictureBox_Avatars
            // 
            this.PictureBox_Avatars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PictureBox_Avatars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Avatars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Avatars.Location = new System.Drawing.Point(18, 102);
            this.PictureBox_Avatars.Name = "PictureBox_Avatars";
            this.PictureBox_Avatars.Size = new System.Drawing.Size(66, 66);
            this.PictureBox_Avatars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_Avatars.TabIndex = 21;
            this.PictureBox_Avatars.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "MojangAPI 不支持 头像和披风";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox_Capes);
            this.Controls.Add(this.PictureBox_Skins);
            this.Controls.Add(this.PictureBox_Avatars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_GetSkin);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioButton_Crafatar);
            this.Controls.Add(this.RadioButton_Mojang);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NullCraft Minecraft Skin Test Version";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Capes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Skins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Capes;
        private System.Windows.Forms.PictureBox PictureBox_Skins;
        private System.Windows.Forms.PictureBox PictureBox_Avatars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_GetSkin;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButton_Crafatar;
        private System.Windows.Forms.RadioButton RadioButton_Mojang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

