using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2inc
{
    public enum EngineType {Gas, Disel, Electro};
    public enum Privod {Front, Back, Full }
    public enum Color {White, Silver, Black, Green, Red, Blue, Purple, Yellow }
    public class Car
    {
        public string Firm, Model, Info;
        public int Year;
        public float EngineV = 3.0f;
        public int milecage = 0;
        public bool Mechanical = true;
        public bool RightWHeel = false;
        public EngineType Engine;
        public Privod Wheel_Drive;
        public Color car_color;
    }
    public partial class work2 : Form
    {
        public work2()
        {
            InitializeComponent();
        }
    }

}
