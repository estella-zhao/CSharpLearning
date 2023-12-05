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

              

                public static GraphicsPath GetRoundRectangle1(Rectangle rectangle, int ltr,int rtr,int rbr,int lbr)
                {
                        int ltrd = 2 * ltr, rtrd = 2 * rtr, rbrd = 2 * rbr, lbrd = 2 * lbr;
                        // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
                        GraphicsPath gp = new GraphicsPath();
                        gp.AddLine(new Point(rectangle.X + ltr, rectangle.Y), new Point(rectangle.Right - rtr, rectangle.Y));
                        if (rtr > 0)
                                gp.AddArc(new Rectangle(rectangle.Right - rtrd, rectangle.Y, rtrd, rtrd), 270F, 90F);

                        gp.AddLine(new Point(rectangle.Right, rectangle.Y + rtr), new Point(rectangle.Right, rectangle.Bottom - rbr));
                        if (rbr > 0)
                                gp.AddArc(new Rectangle(rectangle.Right - rbrd, rectangle.Bottom - rbrd, rbrd, rbrd), 0F, 90F);

                        
                        gp.AddLine(new Point(rectangle.Right - rbr, rectangle.Bottom), new Point(rectangle.X + lbr, rectangle.Bottom));
                        if (lbr > 0)
                                gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - lbrd, lbrd, lbrd), 90F, 90F);

                        gp.AddLine(new Point(rectangle.X, rectangle.Bottom - lbr), new Point(rectangle.X, rectangle.Y + ltr));
                        if (ltr > 0)
                                gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, ltrd, ltrd), 180F, 90F);
                        return gp;
                }
        }
}
