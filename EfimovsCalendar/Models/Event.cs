using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarEvent
    {
        private Color color;
        private string name;
              
        public string Name { get => name; set => name = value; }
        public string getColorStyle()
        {
            return color.Name;
        }

        public void setColor(int color)
        {
            switch (color)
            {
                case 0:
                    this.color = Color.FromArgb(160, 255, 187);
                    break;
                case 2:
                    this.color = Color.FromArgb(255, 86, 103);
                    break;
                case 3:
                    this.color = Color.FromArgb(127, 255, 163);
                    break;
                case 4:
                    this.color = Color.FromArgb(127, 167, 255);
                    break;
                default:
                    this.color = Color.FromArgb(255, 236, 181);
                    break;
            }
        }

        public String getHex()
        {
            Color c = color;
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public CalendarEvent(string name, int color = 0)
        {
            Name = name;
            setColor(color);
        }
    }
}