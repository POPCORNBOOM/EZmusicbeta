
namespace EZMusic
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tc_tabctrl = new System.Windows.Forms.TabControl();
            this.tp_s = new System.Windows.Forms.TabPage();
            this.b_addtodownload = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_server = new System.Windows.Forms.Button();
            this.tb_searchbox = new System.Windows.Forms.TextBox();
            this.cb_getpic = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tp_d = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.b_stopall = new System.Windows.Forms.Button();
            this.b_downall = new System.Windows.Forms.Button();
            this.dgv_downlist = new System.Windows.Forms.DataGridView();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dartist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromserver = new System.Windows.Forms.DataGridViewImageColumn();
            this.tp_set = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.l_dir = new System.Windows.Forms.Label();
            this.b_openfolder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maxthread = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_delafterfinish = new System.Windows.Forms.CheckBox();
            this.btn_savemaxthread = new System.Windows.Forms.Button();
            this.btn_delall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tc_tabctrl.SuspendLayout();
            this.tp_s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tp_d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_downlist)).BeginInit();
            this.tp_set.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tc_tabctrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 300);
            this.panel1.TabIndex = 0;
            // 
            // tc_tabctrl
            // 
            this.tc_tabctrl.Controls.Add(this.tp_s);
            this.tc_tabctrl.Controls.Add(this.tp_d);
            this.tc_tabctrl.Controls.Add(this.tp_set);
            this.tc_tabctrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_tabctrl.Location = new System.Drawing.Point(0, 12);
            this.tc_tabctrl.Name = "tc_tabctrl";
            this.tc_tabctrl.SelectedIndex = 0;
            this.tc_tabctrl.Size = new System.Drawing.Size(533, 288);
            this.tc_tabctrl.TabIndex = 5;
            // 
            // tp_s
            // 
            this.tp_s.Controls.Add(this.b_addtodownload);
            this.tp_s.Controls.Add(this.dgv_user);
            this.tp_s.Controls.Add(this.b_server);
            this.tp_s.Controls.Add(this.tb_searchbox);
            this.tp_s.Controls.Add(this.cb_getpic);
            this.tp_s.Controls.Add(this.btn_search);
            this.tp_s.Location = new System.Drawing.Point(4, 22);
            this.tp_s.Name = "tp_s";
            this.tp_s.Padding = new System.Windows.Forms.Padding(3);
            this.tp_s.Size = new System.Drawing.Size(525, 262);
            this.tp_s.TabIndex = 0;
            this.tp_s.Text = "Search";
            this.tp_s.UseVisualStyleBackColor = true;
            // 
            // b_addtodownload
            // 
            this.b_addtodownload.FlatAppearance.BorderSize = 0;
            this.b_addtodownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addtodownload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_addtodownload.Location = new System.Drawing.Point(477, 214);
            this.b_addtodownload.Name = "b_addtodownload";
            this.b_addtodownload.Size = new System.Drawing.Size(40, 40);
            this.b_addtodownload.TabIndex = 5;
            this.b_addtodownload.Text = "ADD";
            this.b_addtodownload.UseVisualStyleBackColor = true;
            this.b_addtodownload.Click += new System.EventHandler(this.b_addtodownload_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.url,
            this.lrc,
            this.pic,
            this.server});
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_user.Location = new System.Drawing.Point(3, 71);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersWidth = 62;
            this.dgv_user.RowTemplate.Height = 30;
            this.dgv_user.Size = new System.Drawing.Size(519, 188);
            this.dgv_user.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 80;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 80;
            // 
            // url
            // 
            this.url.HeaderText = "url";
            this.url.MinimumWidth = 8;
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 50;
            // 
            // lrc
            // 
            this.lrc.HeaderText = "lrc";
            this.lrc.Name = "lrc";
            this.lrc.ReadOnly = true;
            this.lrc.Width = 50;
            // 
            // pic
            // 
            this.pic.HeaderText = "pic";
            this.pic.Name = "pic";
            this.pic.ReadOnly = true;
            this.pic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // server
            // 
            this.server.HeaderText = "src";
            this.server.Name = "server";
            this.server.ReadOnly = true;
            this.server.Width = 30;
            // 
            // b_server
            // 
            this.b_server.BackgroundImage = global::EZMusic.Properties.Resources.qq;
            this.b_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_server.FlatAppearance.BorderSize = 0;
            this.b_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_server.Location = new System.Drawing.Point(11, 6);
            this.b_server.Name = "b_server";
            this.b_server.Size = new System.Drawing.Size(35, 35);
            this.b_server.TabIndex = 4;
            this.b_server.UseVisualStyleBackColor = true;
            this.b_server.Click += new System.EventHandler(this.b_server_Click);
            // 
            // tb_searchbox
            // 
            this.tb_searchbox.Location = new System.Drawing.Point(7, 46);
            this.tb_searchbox.Margin = new System.Windows.Forms.Padding(2);
            this.tb_searchbox.Name = "tb_searchbox";
            this.tb_searchbox.Size = new System.Drawing.Size(410, 21);
            this.tb_searchbox.TabIndex = 0;
            // 
            // cb_getpic
            // 
            this.cb_getpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_getpic.AutoSize = true;
            this.cb_getpic.Location = new System.Drawing.Point(446, 25);
            this.cb_getpic.Name = "cb_getpic";
            this.cb_getpic.Size = new System.Drawing.Size(78, 16);
            this.cb_getpic.TabIndex = 3;
            this.cb_getpic.Text = "getpiture";
            this.cb_getpic.UseVisualStyleBackColor = true;
            this.cb_getpic.CheckedChanged += new System.EventHandler(this.cb_getpic_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(420, 46);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 19);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tp_d
            // 
            this.tp_d.Controls.Add(this.checkBox1);
            this.tp_d.Controls.Add(this.btn_delall);
            this.tp_d.Controls.Add(this.b_stopall);
            this.tp_d.Controls.Add(this.b_downall);
            this.tp_d.Controls.Add(this.dgv_downlist);
            this.tp_d.Location = new System.Drawing.Point(4, 22);
            this.tp_d.Name = "tp_d";
            this.tp_d.Padding = new System.Windows.Forms.Padding(3);
            this.tp_d.Size = new System.Drawing.Size(525, 262);
            this.tp_d.TabIndex = 1;
            this.tp_d.Text = "download";
            this.tp_d.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "autodownload";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // b_stopall
            // 
            this.b_stopall.Location = new System.Drawing.Point(328, 5);
            this.b_stopall.Name = "b_stopall";
            this.b_stopall.Size = new System.Drawing.Size(92, 23);
            this.b_stopall.TabIndex = 1;
            this.b_stopall.Text = "stop all";
            this.b_stopall.UseVisualStyleBackColor = true;
            this.b_stopall.Click += new System.EventHandler(this.b_stopall_Click);
            // 
            // b_downall
            // 
            this.b_downall.Location = new System.Drawing.Point(426, 5);
            this.b_downall.Name = "b_downall";
            this.b_downall.Size = new System.Drawing.Size(92, 23);
            this.b_downall.TabIndex = 1;
            this.b_downall.Text = "download all";
            this.b_downall.UseVisualStyleBackColor = true;
            this.b_downall.Click += new System.EventHandler(this.b_downall_Click);
            // 
            // dgv_downlist
            // 
            this.dgv_downlist.AllowUserToAddRows = false;
            this.dgv_downlist.AllowUserToDeleteRows = false;
            this.dgv_downlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_downlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dname,
            this.dartist,
            this.sourse,
            this.state,
            this.fromserver});
            this.dgv_downlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_downlist.Location = new System.Drawing.Point(3, 34);
            this.dgv_downlist.Name = "dgv_downlist";
            this.dgv_downlist.ReadOnly = true;
            this.dgv_downlist.RowTemplate.Height = 23;
            this.dgv_downlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_downlist.Size = new System.Drawing.Size(519, 225);
            this.dgv_downlist.TabIndex = 0;
            this.dgv_downlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_downlist_CellDoubleClick);
            // 
            // dname
            // 
            this.dname.HeaderText = "name";
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
            this.dname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dartist
            // 
            this.dartist.HeaderText = "artist";
            this.dartist.Name = "dartist";
            this.dartist.ReadOnly = true;
            this.dartist.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sourse
            // 
            this.sourse.HeaderText = "sourse";
            this.sourse.Name = "sourse";
            this.sourse.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fromserver
            // 
            this.fromserver.HeaderText = "";
            this.fromserver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.fromserver.Name = "fromserver";
            this.fromserver.ReadOnly = true;
            this.fromserver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fromserver.Width = 20;
            // 
            // tp_set
            // 
            this.tp_set.Controls.Add(this.flowLayoutPanel1);
            this.tp_set.Location = new System.Drawing.Point(4, 22);
            this.tp_set.Name = "tp_set";
            this.tp_set.Padding = new System.Windows.Forms.Padding(3);
            this.tp_set.Size = new System.Drawing.Size(525, 262);
            this.tp_set.TabIndex = 2;
            this.tp_set.Text = "settings";
            this.tp_set.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 256);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.l_dir);
            this.panel2.Controls.Add(this.b_openfolder);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 37);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saving dir";
            // 
            // l_dir
            // 
            this.l_dir.AutoSize = true;
            this.l_dir.Location = new System.Drawing.Point(70, 10);
            this.l_dir.Name = "l_dir";
            this.l_dir.Size = new System.Drawing.Size(197, 12);
            this.l_dir.TabIndex = 0;
            this.l_dir.Text = "C:\\Users\\Public\\Music\\NetEZmusic";
            // 
            // b_openfolder
            // 
            this.b_openfolder.Location = new System.Drawing.Point(433, 5);
            this.b_openfolder.Name = "b_openfolder";
            this.b_openfolder.Size = new System.Drawing.Size(75, 23);
            this.b_openfolder.TabIndex = 1;
            this.b_openfolder.Text = "Choose";
            this.b_openfolder.UseVisualStyleBackColor = true;
            this.b_openfolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_savemaxthread);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_maxthread);
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 36);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max downloading threads";
            // 
            // tb_maxthread
            // 
            this.tb_maxthread.Location = new System.Drawing.Point(152, 7);
            this.tb_maxthread.Name = "tb_maxthread";
            this.tb_maxthread.Size = new System.Drawing.Size(49, 21);
            this.tb_maxthread.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_delafterfinish);
            this.panel4.Location = new System.Drawing.Point(3, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 38);
            this.panel4.TabIndex = 7;
            // 
            // cb_delafterfinish
            // 
            this.cb_delafterfinish.AutoSize = true;
            this.cb_delafterfinish.Location = new System.Drawing.Point(3, 10);
            this.cb_delafterfinish.Name = "cb_delafterfinish";
            this.cb_delafterfinish.Size = new System.Drawing.Size(198, 16);
            this.cb_delafterfinish.TabIndex = 3;
            this.cb_delafterfinish.Text = "Delete Mission after finished";
            this.cb_delafterfinish.UseVisualStyleBackColor = true;
            this.cb_delafterfinish.CheckedChanged += new System.EventHandler(this.cb_delafterfinish_CheckedChanged);
            // 
            // btn_savemaxthread
            // 
            this.btn_savemaxthread.Location = new System.Drawing.Point(433, 5);
            this.btn_savemaxthread.Name = "btn_savemaxthread";
            this.btn_savemaxthread.Size = new System.Drawing.Size(75, 23);
            this.btn_savemaxthread.TabIndex = 5;
            this.btn_savemaxthread.Text = "Done";
            this.btn_savemaxthread.UseVisualStyleBackColor = true;
            this.btn_savemaxthread.Click += new System.EventHandler(this.btn_savemaxthread_Click);
            // 
            // btn_delall
            // 
            this.btn_delall.Location = new System.Drawing.Point(230, 5);
            this.btn_delall.Name = "btn_delall";
            this.btn_delall.Size = new System.Drawing.Size(92, 23);
            this.btn_delall.TabIndex = 1;
            this.btn_delall.Text = "delate all";
            this.btn_delall.UseVisualStyleBackColor = true;
            this.btn_delall.Click += new System.EventHandler(this.btn_delall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tc_tabctrl.ResumeLayout(false);
            this.tp_s.ResumeLayout(false);
            this.tp_s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tp_d.ResumeLayout(false);
            this.tp_d.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_downlist)).EndInit();
            this.tp_set.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_searchbox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.CheckBox cb_getpic;
        private System.Windows.Forms.Button b_server;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn lrc;
        private System.Windows.Forms.DataGridViewImageColumn pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.TabControl tc_tabctrl;
        private System.Windows.Forms.TabPage tp_s;
        private System.Windows.Forms.TabPage tp_d;
        private System.Windows.Forms.DataGridView dgv_downlist;
        private System.Windows.Forms.Button b_addtodownload;
        private System.Windows.Forms.Button b_downall;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tp_set;
        private System.Windows.Forms.Button b_openfolder;
        private System.Windows.Forms.Label l_dir;
        private System.Windows.Forms.Button b_stopall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dartist;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewImageColumn fromserver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maxthread;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cb_delafterfinish;
        private System.Windows.Forms.Button btn_savemaxthread;
        private System.Windows.Forms.Button btn_delall;
    }
}

