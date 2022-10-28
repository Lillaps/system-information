
namespace kursach_winforms
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Button();
            this.bios = new System.Windows.Forms.Button();
            this.hdd_partition = new System.Windows.Forms.Button();
            this.hdd = new System.Windows.Forms.Button();
            this.keyboard = new System.Windows.Forms.Button();
            this.motherboard = new System.Windows.Forms.Button();
            this.mouse = new System.Windows.Forms.Button();
            this.Video_card = new System.Windows.Forms.Button();
            this.monitor = new System.Windows.Forms.Button();
            this.network_adapters = new System.Windows.Forms.Button();
            this.sound_card = new System.Windows.Forms.Button();
            this.active_apps = new System.Windows.Forms.Button();
            this.info_Windows = new System.Windows.Forms.Button();
            this.info_users = new System.Windows.Forms.Button();
            this.to_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the necessary information";
            // 
            // cpu
            // 
            this.cpu.Location = new System.Drawing.Point(96, 89);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(95, 28);
            this.cpu.TabIndex = 1;
            this.cpu.Text = "CPU";
            this.cpu.UseVisualStyleBackColor = true;
            this.cpu.Click += new System.EventHandler(this.cpu_Click);
            // 
            // bios
            // 
            this.bios.Location = new System.Drawing.Point(219, 89);
            this.bios.Name = "bios";
            this.bios.Size = new System.Drawing.Size(155, 28);
            this.bios.TabIndex = 2;
            this.bios.Text = "BIOS";
            this.bios.UseVisualStyleBackColor = true;
            this.bios.Click += new System.EventHandler(this.bios_Click);
            // 
            // hdd_partition
            // 
            this.hdd_partition.Location = new System.Drawing.Point(397, 89);
            this.hdd_partition.Name = "hdd_partition";
            this.hdd_partition.Size = new System.Drawing.Size(132, 28);
            this.hdd_partition.TabIndex = 3;
            this.hdd_partition.Text = "HDD partition";
            this.hdd_partition.UseVisualStyleBackColor = true;
            // 
            // hdd
            // 
            this.hdd.Location = new System.Drawing.Point(555, 89);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(109, 28);
            this.hdd.TabIndex = 4;
            this.hdd.Text = "HDD";
            this.hdd.UseVisualStyleBackColor = true;
            this.hdd.Click += new System.EventHandler(this.hdd_Click);
            // 
            // keyboard
            // 
            this.keyboard.Location = new System.Drawing.Point(96, 168);
            this.keyboard.Name = "keyboard";
            this.keyboard.Size = new System.Drawing.Size(95, 28);
            this.keyboard.TabIndex = 5;
            this.keyboard.Text = "Keyboard";
            this.keyboard.UseVisualStyleBackColor = true;
            this.keyboard.Click += new System.EventHandler(this.keyboard_Click);
            // 
            // motherboard
            // 
            this.motherboard.Location = new System.Drawing.Point(219, 168);
            this.motherboard.Name = "motherboard";
            this.motherboard.Size = new System.Drawing.Size(155, 28);
            this.motherboard.TabIndex = 6;
            this.motherboard.Text = "Motherboard";
            this.motherboard.UseVisualStyleBackColor = true;
            this.motherboard.Click += new System.EventHandler(this.motherboard_Click);
            // 
            // mouse
            // 
            this.mouse.Location = new System.Drawing.Point(397, 168);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(132, 28);
            this.mouse.TabIndex = 7;
            this.mouse.Text = "Mouse";
            this.mouse.UseVisualStyleBackColor = true;
            this.mouse.Click += new System.EventHandler(this.mouse_Click);
            // 
            // Video_card
            // 
            this.Video_card.Location = new System.Drawing.Point(555, 168);
            this.Video_card.Name = "Video_card";
            this.Video_card.Size = new System.Drawing.Size(109, 28);
            this.Video_card.TabIndex = 8;
            this.Video_card.Text = "Video card";
            this.Video_card.UseVisualStyleBackColor = true;
            this.Video_card.Click += new System.EventHandler(this.Video_card_Click);
            // 
            // monitor
            // 
            this.monitor.Location = new System.Drawing.Point(96, 249);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(95, 28);
            this.monitor.TabIndex = 9;
            this.monitor.Text = "Monitor";
            this.monitor.UseVisualStyleBackColor = true;
            this.monitor.Click += new System.EventHandler(this.monitor_Click);
            // 
            // network_adapters
            // 
            this.network_adapters.Location = new System.Drawing.Point(219, 249);
            this.network_adapters.Name = "network_adapters";
            this.network_adapters.Size = new System.Drawing.Size(155, 28);
            this.network_adapters.TabIndex = 10;
            this.network_adapters.Text = "Network adapters";
            this.network_adapters.UseVisualStyleBackColor = true;
            this.network_adapters.Click += new System.EventHandler(this.network_adapters_Click);
            // 
            // sound_card
            // 
            this.sound_card.Location = new System.Drawing.Point(397, 249);
            this.sound_card.Name = "sound_card";
            this.sound_card.Size = new System.Drawing.Size(132, 28);
            this.sound_card.TabIndex = 11;
            this.sound_card.Text = "Sound card";
            this.sound_card.UseVisualStyleBackColor = true;
            this.sound_card.Click += new System.EventHandler(this.sound_card_Click);
            // 
            // active_apps
            // 
            this.active_apps.Location = new System.Drawing.Point(555, 249);
            this.active_apps.Name = "active_apps";
            this.active_apps.Size = new System.Drawing.Size(109, 28);
            this.active_apps.TabIndex = 12;
            this.active_apps.Text = "Active apps";
            this.active_apps.UseVisualStyleBackColor = true;
            this.active_apps.Click += new System.EventHandler(this.active_apps_Click);
            // 
            // info_Windows
            // 
            this.info_Windows.Location = new System.Drawing.Point(147, 326);
            this.info_Windows.Name = "info_Windows";
            this.info_Windows.Size = new System.Drawing.Size(227, 28);
            this.info_Windows.TabIndex = 13;
            this.info_Windows.Text = "Time of start/finish Windows";
            this.info_Windows.UseVisualStyleBackColor = true;
            this.info_Windows.Click += new System.EventHandler(this.info_Windows_Click);
            // 
            // info_users
            // 
            this.info_users.Location = new System.Drawing.Point(397, 326);
            this.info_users.Name = "info_users";
            this.info_users.Size = new System.Drawing.Size(209, 28);
            this.info_users.TabIndex = 14;
            this.info_users.Text = "Time of user login";
            this.info_users.UseVisualStyleBackColor = true;
            // 
            // to_file
            // 
            this.to_file.Location = new System.Drawing.Point(308, 391);
            this.to_file.Name = "to_file";
            this.to_file.Size = new System.Drawing.Size(157, 36);
            this.to_file.TabIndex = 15;
            this.to_file.Text = "Export info to file";
            this.to_file.UseVisualStyleBackColor = true;
            this.to_file.Click += new System.EventHandler(this.to_file_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.to_file);
            this.Controls.Add(this.info_users);
            this.Controls.Add(this.info_Windows);
            this.Controls.Add(this.active_apps);
            this.Controls.Add(this.sound_card);
            this.Controls.Add(this.network_adapters);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.Video_card);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.motherboard);
            this.Controls.Add(this.keyboard);
            this.Controls.Add(this.hdd);
            this.Controls.Add(this.hdd_partition);
            this.Controls.Add(this.bios);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cpu;
        private System.Windows.Forms.Button bios;
        private System.Windows.Forms.Button hdd_partition;
        private System.Windows.Forms.Button hdd;
        private System.Windows.Forms.Button keyboard;
        private System.Windows.Forms.Button motherboard;
        private System.Windows.Forms.Button mouse;
        private System.Windows.Forms.Button Video_card;
        private System.Windows.Forms.Button monitor;
        private System.Windows.Forms.Button network_adapters;
        private System.Windows.Forms.Button sound_card;
        private System.Windows.Forms.Button active_apps;
        private System.Windows.Forms.Button info_Windows;
        private System.Windows.Forms.Button info_users;
        private System.Windows.Forms.Button to_file;
    }
}

