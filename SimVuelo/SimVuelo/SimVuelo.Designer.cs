namespace SimVuelo
{
    partial class SimVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimVuelo));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tab = new System.Windows.Forms.TabControl();
            this.Mapa = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_mapa = new System.Windows.Forms.ComboBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.Simular = new System.Windows.Forms.Button();
            this.Avion = new System.Windows.Forms.TabPage();
            this.panel_Avion = new System.Windows.Forms.Panel();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.txt_proviende = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Distancia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Combustible = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_VF = new System.Windows.Forms.TextBox();
            this.txt_VA = new System.Windows.Forms.TextBox();
            this.txt_VI = new System.Windows.Forms.TextBox();
            this.txt_Posicion = new System.Windows.Forms.TextBox();
            this.txt_hLanding = new System.Windows.Forms.TextBox();
            this.txt_Htakeoff = new System.Windows.Forms.TextBox();
            this.txt_numPas = new System.Windows.Forms.TextBox();
            this.txt_numAvion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gmap2 = new GMap.NET.WindowsForms.GMapControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_AirName = new System.Windows.Forms.TextBox();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.txt_latitud = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Tab.SuspendLayout();
            this.Mapa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Avion.SuspendLayout();
            this.panel_Avion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(784, 537);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 3D;
            this.gmap.Click += new System.EventHandler(this.gmap_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.Mapa);
            this.Tab.Controls.Add(this.Avion);
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Location = new System.Drawing.Point(-2, 2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1101, 593);
            this.Tab.TabIndex = 2;
            // 
            // Mapa
            // 
            this.Mapa.Controls.Add(this.panel2);
            this.Mapa.Controls.Add(this.gmap);
            this.Mapa.Location = new System.Drawing.Point(4, 22);
            this.Mapa.Name = "Mapa";
            this.Mapa.Padding = new System.Windows.Forms.Padding(3);
            this.Mapa.Size = new System.Drawing.Size(1093, 567);
            this.Mapa.TabIndex = 0;
            this.Mapa.Text = "Mapa";
            this.Mapa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cmb_mapa);
            this.panel2.Controls.Add(this.btn_Stop);
            this.panel2.Controls.Add(this.Simular);
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 537);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(88, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tipo de mapa";
            // 
            // cmb_mapa
            // 
            this.cmb_mapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_mapa.FormattingEnabled = true;
            this.cmb_mapa.Location = new System.Drawing.Point(16, 51);
            this.cmb_mapa.Name = "cmb_mapa";
            this.cmb_mapa.Size = new System.Drawing.Size(145, 21);
            this.cmb_mapa.TabIndex = 9;
            this.cmb_mapa.SelectedIndexChanged += new System.EventHandler(this.cmb_mapa_SelectedIndexChanged);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stop.Location = new System.Drawing.Point(156, 178);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(131, 36);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "Detener";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click_1);
            // 
            // Simular
            // 
            this.Simular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Simular.Location = new System.Drawing.Point(15, 178);
            this.Simular.Name = "Simular";
            this.Simular.Size = new System.Drawing.Size(131, 36);
            this.Simular.TabIndex = 7;
            this.Simular.Text = "Simular";
            this.Simular.UseVisualStyleBackColor = true;
            this.Simular.Click += new System.EventHandler(this.Simular_Click_1);
            // 
            // Avion
            // 
            this.Avion.Controls.Add(this.panel_Avion);
            this.Avion.Controls.Add(this.gmap2);
            this.Avion.Location = new System.Drawing.Point(4, 22);
            this.Avion.Name = "Avion";
            this.Avion.Padding = new System.Windows.Forms.Padding(3);
            this.Avion.Size = new System.Drawing.Size(1093, 567);
            this.Avion.TabIndex = 1;
            this.Avion.Text = "Avion";
            this.Avion.UseVisualStyleBackColor = true;
            this.Avion.Leave += new System.EventHandler(this.Avion_Leave);
            // 
            // panel_Avion
            // 
            this.panel_Avion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Avion.Controls.Add(this.txt_destino);
            this.panel_Avion.Controls.Add(this.txt_proviende);
            this.panel_Avion.Controls.Add(this.label12);
            this.panel_Avion.Controls.Add(this.label13);
            this.panel_Avion.Controls.Add(this.label11);
            this.panel_Avion.Controls.Add(this.txt_Distancia);
            this.panel_Avion.Controls.Add(this.label10);
            this.panel_Avion.Controls.Add(this.txt_Combustible);
            this.panel_Avion.Controls.Add(this.label9);
            this.panel_Avion.Controls.Add(this.txt_VF);
            this.panel_Avion.Controls.Add(this.txt_VA);
            this.panel_Avion.Controls.Add(this.txt_VI);
            this.panel_Avion.Controls.Add(this.txt_Posicion);
            this.panel_Avion.Controls.Add(this.txt_hLanding);
            this.panel_Avion.Controls.Add(this.txt_Htakeoff);
            this.panel_Avion.Controls.Add(this.txt_numPas);
            this.panel_Avion.Controls.Add(this.txt_numAvion);
            this.panel_Avion.Controls.Add(this.label5);
            this.panel_Avion.Controls.Add(this.label6);
            this.panel_Avion.Controls.Add(this.label7);
            this.panel_Avion.Controls.Add(this.label8);
            this.panel_Avion.Controls.Add(this.label3);
            this.panel_Avion.Controls.Add(this.label4);
            this.panel_Avion.Controls.Add(this.label2);
            this.panel_Avion.Controls.Add(this.label1);
            this.panel_Avion.Location = new System.Drawing.Point(745, 3);
            this.panel_Avion.Name = "panel_Avion";
            this.panel_Avion.Size = new System.Drawing.Size(348, 545);
            this.panel_Avion.TabIndex = 2;
            this.panel_Avion.Visible = false;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(190, 169);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.ReadOnly = true;
            this.txt_destino.Size = new System.Drawing.Size(134, 20);
            this.txt_destino.TabIndex = 66;
            // 
            // txt_proviende
            // 
            this.txt_proviende.Location = new System.Drawing.Point(190, 130);
            this.txt_proviende.Name = "txt_proviende";
            this.txt_proviende.ReadOnly = true;
            this.txt_proviende.Size = new System.Drawing.Size(134, 20);
            this.txt_proviende.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(71, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 64;
            this.label12.Text = "Destino";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(71, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 63;
            this.label13.Text = "Sale";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(74, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 23);
            this.label11.TabIndex = 62;
            this.label11.Text = "Caracteristicas del Avion";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Distancia
            // 
            this.txt_Distancia.Location = new System.Drawing.Point(190, 483);
            this.txt_Distancia.Name = "txt_Distancia";
            this.txt_Distancia.ReadOnly = true;
            this.txt_Distancia.Size = new System.Drawing.Size(134, 20);
            this.txt_Distancia.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(71, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 60;
            this.label10.Text = "Distancia";
            // 
            // txt_Combustible
            // 
            this.txt_Combustible.Location = new System.Drawing.Point(190, 443);
            this.txt_Combustible.Name = "txt_Combustible";
            this.txt_Combustible.ReadOnly = true;
            this.txt_Combustible.Size = new System.Drawing.Size(134, 20);
            this.txt_Combustible.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(71, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Nivel Combustible";
            // 
            // txt_VF
            // 
            this.txt_VF.Location = new System.Drawing.Point(190, 404);
            this.txt_VF.Name = "txt_VF";
            this.txt_VF.ReadOnly = true;
            this.txt_VF.Size = new System.Drawing.Size(134, 20);
            this.txt_VF.TabIndex = 57;
            // 
            // txt_VA
            // 
            this.txt_VA.Location = new System.Drawing.Point(190, 365);
            this.txt_VA.Name = "txt_VA";
            this.txt_VA.ReadOnly = true;
            this.txt_VA.Size = new System.Drawing.Size(134, 20);
            this.txt_VA.TabIndex = 56;
            // 
            // txt_VI
            // 
            this.txt_VI.Location = new System.Drawing.Point(190, 324);
            this.txt_VI.Name = "txt_VI";
            this.txt_VI.ReadOnly = true;
            this.txt_VI.Size = new System.Drawing.Size(134, 20);
            this.txt_VI.TabIndex = 55;
            // 
            // txt_Posicion
            // 
            this.txt_Posicion.Location = new System.Drawing.Point(190, 285);
            this.txt_Posicion.Name = "txt_Posicion";
            this.txt_Posicion.ReadOnly = true;
            this.txt_Posicion.Size = new System.Drawing.Size(134, 20);
            this.txt_Posicion.TabIndex = 54;
            // 
            // txt_hLanding
            // 
            this.txt_hLanding.Location = new System.Drawing.Point(190, 245);
            this.txt_hLanding.Name = "txt_hLanding";
            this.txt_hLanding.ReadOnly = true;
            this.txt_hLanding.Size = new System.Drawing.Size(134, 20);
            this.txt_hLanding.TabIndex = 53;
            // 
            // txt_Htakeoff
            // 
            this.txt_Htakeoff.Location = new System.Drawing.Point(190, 206);
            this.txt_Htakeoff.Name = "txt_Htakeoff";
            this.txt_Htakeoff.ReadOnly = true;
            this.txt_Htakeoff.Size = new System.Drawing.Size(134, 20);
            this.txt_Htakeoff.TabIndex = 52;
            // 
            // txt_numPas
            // 
            this.txt_numPas.Location = new System.Drawing.Point(190, 95);
            this.txt_numPas.Name = "txt_numPas";
            this.txt_numPas.ReadOnly = true;
            this.txt_numPas.Size = new System.Drawing.Size(134, 20);
            this.txt_numPas.TabIndex = 51;
            // 
            // txt_numAvion
            // 
            this.txt_numAvion.Location = new System.Drawing.Point(190, 56);
            this.txt_numAvion.Name = "txt_numAvion";
            this.txt_numAvion.ReadOnly = true;
            this.txt_numAvion.Size = new System.Drawing.Size(134, 20);
            this.txt_numAvion.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(71, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Velocidad Landing";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(71, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Velocidad Fly";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(74, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Velocidad Take Off";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(71, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Posicion Actual";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(71, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Hora de Landing";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(71, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hora de Take Off";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "# de pasajeros";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "# de avion";
            // 
            // gmap2
            // 
            this.gmap2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap2.Bearing = 0F;
            this.gmap2.CanDragMap = true;
            this.gmap2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap2.GrayScaleMode = false;
            this.gmap2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap2.LevelsKeepInMemmory = 5;
            this.gmap2.Location = new System.Drawing.Point(6, 0);
            this.gmap2.MarkersEnabled = true;
            this.gmap2.MaxZoom = 18;
            this.gmap2.MinZoom = 2;
            this.gmap2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap2.Name = "gmap2";
            this.gmap2.NegativeMode = false;
            this.gmap2.PolygonsEnabled = true;
            this.gmap2.RetryLoadTile = 0;
            this.gmap2.RoutesEnabled = true;
            this.gmap2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap2.ShowTileGridLines = false;
            this.gmap2.Size = new System.Drawing.Size(722, 537);
            this.gmap2.TabIndex = 1;
            this.gmap2.Zoom = 3D;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 567);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txt_AirName);
            this.panel1.Controls.Add(this.txt_longitud);
            this.panel1.Controls.Add(this.txt_latitud);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 472);
            this.panel1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Location = new System.Drawing.Point(341, 319);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(165, 20);
            this.txt_id.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "ID:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Location = new System.Drawing.Point(341, 276);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(137, 36);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Location = new System.Drawing.Point(166, 276);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(137, 36);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(7, 276);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Nombre:";
            // 
            // txt_AirName
            // 
            this.txt_AirName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AirName.Location = new System.Drawing.Point(91, 319);
            this.txt_AirName.Multiline = true;
            this.txt_AirName.Name = "txt_AirName";
            this.txt_AirName.Size = new System.Drawing.Size(165, 20);
            this.txt_AirName.TabIndex = 24;
            // 
            // txt_longitud
            // 
            this.txt_longitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_longitud.Location = new System.Drawing.Point(341, 364);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(165, 20);
            this.txt_longitud.TabIndex = 22;
            // 
            // txt_latitud
            // 
            this.txt_latitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_latitud.Location = new System.Drawing.Point(91, 364);
            this.txt_latitud.Name = "txt_latitud";
            this.txt_latitud.Size = new System.Drawing.Size(165, 20);
            this.txt_latitud.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Longitud:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Latitud:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(580, 270);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            // 
            // SimVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 573);
            this.Controls.Add(this.Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimVuelo";
            this.Text = "Simulador de Vuelo";
            this.Tab.ResumeLayout(false);
            this.Mapa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Avion.ResumeLayout(false);
            this.panel_Avion.ResumeLayout(false);
            this.panel_Avion.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Mapa;
        private System.Windows.Forms.TabPage Avion;
        private GMap.NET.WindowsForms.GMapControl gmap2;
        private System.Windows.Forms.Panel panel_Avion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Distancia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Combustible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_VF;
        private System.Windows.Forms.TextBox txt_VA;
        private System.Windows.Forms.TextBox txt_VI;
        private System.Windows.Forms.TextBox txt_Posicion;
        private System.Windows.Forms.TextBox txt_hLanding;
        private System.Windows.Forms.TextBox txt_Htakeoff;
        private System.Windows.Forms.TextBox txt_numPas;
        private System.Windows.Forms.TextBox txt_numAvion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.TextBox txt_proviende;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_AirName;
        private System.Windows.Forms.TextBox txt_longitud;
        private System.Windows.Forms.TextBox txt_latitud;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_mapa;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button Simular;
    }
}

