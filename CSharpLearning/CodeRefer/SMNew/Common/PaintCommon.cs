using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
       public  class PaintCommon
        {
                /// <summary>
                /// 根据矩形画圆角
                /// </summary>
                /// <param name="rectangle"></param>
                /// <param name="r"></param>
                /// <returns></returns>
                public static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
                {
                        int l = 2 * r;
                        // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
                        GraphicsPath gp = new GraphicsPath();
                        gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
                        gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

                        gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
                        gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

                        gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
                        gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

                        gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
                        gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
                        return gp;
                }



        public static void DrawControl(Graphics g, Rectangle r, int radius,int borderWidth,Color borderColor,Color bgColor1,Color bgColor2, LinearGradientMode gradientMode)
        {
            r.Width -= 1;
            r.Height -= 1;

            if (borderWidth > 0)//边框粗细》0
            {
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    GraphicsPath path = new GraphicsPath();
                    path = PaintCommon.GetRoundRectangle(r, radius);//绘制圆角矩形路径
                    g.DrawPath(pen, path);
                }
            }
            //背景区域的矩形
            Rectangle rect1 = new Rectangle(r.X + borderWidth, r.Y + borderWidth, r.Width - 2 * borderWidth, r.Height - 2 * borderWidth);
            //获取背景区域的圆角矩形
            GraphicsPath path1 = PaintCommon.GetRoundRectangle(rect1, radius);
            if (bgColor2 != Color.Transparent)
            {
                //线型渐变画刷
                LinearGradientBrush brush = new LinearGradientBrush(rect1, bgColor1, bgColor2, gradientMode);
                g.FillPath(brush, path1);//填充圆角矩形内部
            }
            else
            {
                Brush b = new SolidBrush(bgColor1);
                g.FillPath(b, path1);//填充圆角矩形内部
            }
        }
    }
}
