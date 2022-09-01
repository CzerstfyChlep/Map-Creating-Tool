using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CreateAMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            do
            {
                Console.Clear();
                int sx = 800;
                int sy = 600;
                int bigLand = 1;
                int normalland = 2;
                Console.WriteLine($"Template: x:{sx} y:{sy} [-n] [big:{bigLand}] [nor:{normalland}] [t:usml/sml/med/big/ubig] [to:isl/cont/pan] [dbg:sea] [langtest]");
                res = Console.ReadLine();
                if (res == "exit")
                    break;
                Console.Clear();
                bool noBord = false;
                bool onlySea = false;
                Random r = new Random();
                LanguageClass.InitialiseLanguagePack();
                List<string> spl = res.Split(' ').ToList();
                string spectest = spl.Find(x => x.Contains("langtest"));
                string specoutput = spl.Find(x => x.Contains("langout"));
                if (spectest != null)
                {
                    string toshow = "English: ";
                    for (int en = 0; en < 10; en++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.en }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nJapanese: ";
                    for (int jp = 0; jp < 10; jp++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.jp }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nScandinavian (Swedish): ";
                    for (int sc = 0; sc < 10; sc++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.sc }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nPolish: ";
                    for (int pl = 0; pl < 10; pl++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.pl }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nNahuatl: ";
                    for (int nh = 0; nh < 10; nh++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.nh }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nGerman: ";
                    for (int de = 0; de < 10; de++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.de }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nRussian: ";
                    for (int ru = 0; ru < 10; ru++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.ru }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nChinese: ";
                    for (int zh = 0; zh < 10; zh++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.zh }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nMongol: ";
                    for (int mn = 0; mn < 10; mn++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.mn }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nDutch: ";
                    for (int mn = 0; mn < 10; mn++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.mn }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nSpanish: ";
                    for (int es = 0; es < 10; es++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.es }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nFrench: ";
                    for (int fr = 0; fr < 10; fr++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.fr }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nItalian: ";
                    for (int it = 0; it < 10; it++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.it }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nLatin: ";
                    for (int la = 0; la < 10; la++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.la }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nGreek: ";
                    for (int gr = 0; gr < 10; gr++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.gr }) + ", ";
                    Console.WriteLine(toshow);
                    Console.ReadLine();
                    continue;
                    //Language.
                }
                else if(specoutput != null)
                {
                    string toshow = "";
                    for (int en = 0; en < 1000; en++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.en }) + "\n";
                    File.WriteAllText("language\\English.txt", toshow);
                    toshow = "";
                    for (int jp = 0; jp < 1000; jp++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.jp }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nScandinavian (Swedish): ";
                    for (int sc = 0; sc < 10; sc++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.sc }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nPolish: ";
                    for (int pl = 0; pl < 10; pl++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.pl }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nNahuatl: ";
                    for (int nh = 0; nh < 10; nh++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.nh }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nGerman: ";
                    for (int de = 0; de < 10; de++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.de }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nRussian: ";
                    for (int ru = 0; ru < 10; ru++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.ru }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nChinese: ";
                    for (int zh = 0; zh < 10; zh++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.zh }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nMongol: ";
                    for (int mn = 0; mn < 10; mn++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.mn }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nDutch: ";
                    for (int mn = 0; mn < 10; mn++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.mn }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nSpanish: ";
                    for (int es = 0; es < 10; es++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.es }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nFrench: ";
                    for (int fr = 0; fr < 10; fr++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.fr }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nItalian: ";
                    for (int it = 0; it < 10; it++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.it }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nLatin: ";
                    for (int la = 0; la < 10; la++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.la }) + ", ";
                    Console.WriteLine(toshow);
                    toshow = "\nGreek: ";
                    for (int gr = 0; gr < 10; gr++)
                        toshow += LanguageClass.GenerateAWord(r, new LanguageClass.Language[] { LanguageClass.Language.gr }) + ", ";
                    Console.WriteLine(toshow);
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    string specD = spl.Find(x => x.Contains("dbg:"));
                    string specT = spl.Find(x => x.Contains("t:"));
                    if (specT != null)
                    {
                        string specTO = spl.Find(x => x.Contains("to:"));
                        switch (specT.Split(':')[1])
                        {
                            case "usml":
                                sx = 400;
                                sy = 300;
                                bigLand = 0;
                                normalland = 2;
                                break;
                            case "sml":
                                break;
                            case "med":
                                sx = 1400;
                                sy = 1000;
                                bigLand = 2;
                                normalland = 4;
                                break;
                            case "big":
                                sx = 2000;
                                sy = 1600;
                                bigLand = 3;
                                normalland = 8;
                                break;
                            case "ubig":
                                sx = 3200;
                                sy = 2800;
                                bigLand = 5;
                                normalland = 12;
                                break;
                            default:
                                goto case "med";
                        }

                        if (specTO != null)
                        {
                            switch (specTO.Split(':')[1])
                            {
                                case "isl":
                                    bigLand = 0;
                                    normalland = (int)(normalland * 1.5f);
                                    break;
                                case "pan":
                                    bigLand = (int)(bigLand * 1.5f);
                                    normalland = 0;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        string specX = spl.Find(x => x.Contains("x:"));
                        if (specX != null)
                            sx = int.Parse(specX.Split(':')[1]);
                        string specY = spl.Find(x => x.Contains("y:"));
                        if (specY != null)
                            sy = int.Parse(specY.Split(':')[1]);
                        string specBland = spl.Find(x => x.Contains("big:"));
                        if (specBland != null)
                            bigLand = int.Parse(specBland.Split(':')[1]);
                        string specNland = spl.Find(x => x.Contains("nor:"));
                        if (specNland != null)
                            normalland = int.Parse(specNland.Split(':')[1]);
                    }
                    string specNoBord = spl.Find(x => x.Contains("-n"));
                    if (specNoBord != null)
                        noBord = true;
                    if (specD != null)
                    {
                        switch (specD.Split(':')[1])
                        {
                            case "sea":
                                onlySea = true;
                                break;
                        }
                    }
                }




                int ymax = (int)Math.Sqrt(sy);
                int xmax = (int)Math.Sqrt(sx);
                int[,] map = new int[sy + 1, sx + 1];
                List<Cluster> clusters = new List<Cluster>();
                for (int y = 0; y < ymax; y++)
                {
                    for (int x = 0; x < xmax; x++)
                    {
                        clusters.Add(new Cluster(x, y, sx / (xmax), sy / (ymax)));
                    }
                }
                int currentid = 0;
                List<Province> provinces = new List<Province>();
                bool cont = false;
                Console.WriteLine("Start: " + DateTime.Now);
                int iterations = 0;
                if (!onlySea)
                {
                    do
                    {
                        cont = false;
                        iterations++;
                        Console.SetCursorPosition(0, 1);
                        Console.Write("                            ");
                        Console.SetCursorPosition(0, 1);
                        Console.Write("Iterations: " + iterations);
                        if (iterations % 5 == 0)
                        {
                            Console.SetCursorPosition(0, 2);
                            Console.Write("                            ");
                            Console.SetCursorPosition(0, 2);
                        }
                        int sum = 0;
                        if (iterations < 150)
                        {
                            Point p = new Point(-1, -1);
                            for (int pr = 0; pr < 1000; pr++)
                            {
                                int t = 0;
                                do
                                {
                                    p = new Point(r.Next(1, sx - 1), r.Next(1, sy - 1));
                                    t++;
                                }
                                while (map[p.y, p.x] != 0 && t < 10);
                                if (t == 10)
                                    break;
                                else
                                {
                                    Province pro = new Province();
                                    pro.points.Add(p);
                                    pro.id = currentid;
                                    provinces.Add(pro);
                                    map[p.y, p.x] = currentid;
                                    currentid++;
                                }
                            }
                        }
                        List<Request> requests = new List<Request>();
                        foreach (Cluster c in clusters)
                        {
                            if (!c.done)
                            {
                                cont = true;
                                bool clear = true;
                                for (int a = 0; a < c.sizey; a++)
                                {
                                    for (int b = 0; b < c.sizex; b++)
                                    {
                                        int truea = 2 + a + c.y * c.sizey;
                                        int trueb = 2 + b + c.x * c.sizex;
                                        if (truea >= sy || trueb >= sx)
                                        {
                                            c.done = true;
                                            break;
                                        }
                                        if (map[truea, trueb] == 0)
                                        {
                                            clear = false;
                                            int n1 = map[truea - 1, trueb];
                                            int n2 = map[truea + 1, trueb];
                                            int n3 = map[truea, trueb - 1];
                                            int n4 = map[truea, trueb + 1];
                                            List<int> arr = new List<int> { n1, n2, n3, n4 };
                                            arr = arr.Where(x => x != 0).ToList();
                                            if (arr.Any() && r.Next(0, 2) == 1)
                                            {
                                                int n = arr[r.Next(0, arr.Count)];
                                                if (n != -1)
                                                    provinces[n].points.Add(new Point(trueb, truea));
                                                requests.Add(new Request(trueb, truea, n));
                                            }
                                        }
                                        else
                                            sum++;
                                    }
                                }
                                c.done = clear;
                            }
                            else
                                sum += c.sizex * c.sizey;
                        }

                        if (iterations % 5 == 0)
                        {
                            Console.Write("Pixels: " + sum + "/" + (sx - 4) * (sy - 4));
                        }
                        foreach (Request req in requests)
                        {
                            map[req.y, req.x] = req.v;
                        }
                    }
                    while (cont && iterations < 2000);
                    Console.Clear();
                    Console.WriteLine("Finished creating: " + DateTime.Now);
                    int summ = 0;

                    for (int patch = 0; patch < 5; patch++)
                    {
                        foreach (Province province in provinces)
                        {
                            List<Point> remove = new List<Point>();
                            if (province != null && province.points.Count < 11)
                            {
                                foreach (Point p in province.points)
                                {
                                    int n1 = map[p.y - 1, p.x];
                                    int n2 = map[p.y + 1, p.x];
                                    int n3 = map[p.y, p.x - 1];
                                    int n4 = map[p.y, p.x + 1];
                                    List<int> arr = new List<int> { n1, n2, n3, n4 };
                                    arr = arr.Where(x => x != 0 && x != map[p.y, p.x]).ToList();
                                    if (arr.Any())
                                    {
                                        int num = r.Next(0, arr.Count);
                                        map[p.y, p.x] = arr[num];
                                        if (arr[num] != -1)
                                            provinces[arr[num]].points.Add(p);
                                        remove.Add(p);
                                        summ++;
                                    }
                                }
                                province.points.RemoveAll(x => remove.Contains(x));
                            }
                        }
                    }

                    Console.WriteLine("Finished patching\nPatched pixels: " + summ);
                }
                Bitmap bmp = new Bitmap(sx + 1, sy + 1);

                Bitmap LandMap = new Bitmap(sx + 1, sy + 1);
                int lakes = sx / 350;
                using (Graphics g = Graphics.FromImage(LandMap))
                {
                    g.Clear(Color.White);
                    List<RectangleF> boxes = new List<RectangleF>();
                    List<RectangleF> fboxes = new List<RectangleF>();

                    float xsize = sx / 16;
                    float ysize = sy / 16;

                    for (int szy = 0; szy < 16; szy++)
                    {
                        for (int szx = 0; szx < 16; szx++)
                        {
                            boxes.Add(new RectangleF(szx * xsize, szy * ysize, xsize, ysize));
                        }
                    }
                    int bigones = 0;
                    for (int a = 0; a < 3 + (int)Math.Floor(sx / 1000f); a++)
                    {
                        if (a == 0)
                        {

                            for (int con = 0; con < 11; con++)
                            {
                                int boxn = r.Next(0, boxes.Count);
                                g.FillRectangle(Brushes.Black, boxes[boxn]);
                                boxes.RemoveAt(boxn);
                            }
                        }

                        for (int t = 0; t < 5; t++)
                        {
                            foreach (RectangleF rect in boxes)
                            {
                                int gchance = 1000;
                                Point chk = new Point((int)rect.X, (int)rect.Y - 1);
                                if (chk.y >= 0 && LandMap.GetPixel(chk.x, chk.y) == Color.FromArgb(255, 0, 0, 0))
                                    gchance -= 4;
                                chk = new Point((int)rect.X - 1, (int)rect.Y);
                                if (chk.x >= 0 && LandMap.GetPixel(chk.x, chk.y) == Color.FromArgb(255, 0, 0, 0))
                                    gchance -= 4;
                                chk = new Point((int)rect.X + (int)xsize + 1, (int)rect.Y);
                                if (chk.x < sx && LandMap.GetPixel(chk.x, chk.y) == Color.FromArgb(255, 0, 0, 0))
                                    gchance -= 4;
                                chk = new Point((int)rect.X, (int)rect.Y + (int)ysize + 1);
                                if (chk.y < sy && LandMap.GetPixel(chk.x, chk.y) == Color.FromArgb(255, 0, 0, 0))
                                    gchance -= 4;
                                if (gchance != 1000)
                                    gchance -= 980;

                                if (r.Next(0, gchance) == 0 && rect.X != 0 && rect.Y != 0 && (a > 0 || bigones < 61))
                                {
                                    g.FillRectangle(Brushes.Black, rect);
                                    fboxes.Add(rect);
                                    if (a > 0)
                                        bigones++;
                                }
                            }
                            boxes.RemoveAll(x => fboxes.Contains(x));
                            ShowProgress(3, fboxes.Count, "Boxes filled");
                        }
                        xsize /= 2;
                        ysize /= 2;
                        List<RectangleF> nboxes = new List<RectangleF>();
                        foreach (RectangleF rect in boxes)
                        {
                            nboxes.Add(new RectangleF(rect.X, rect.Y, xsize, ysize));
                            nboxes.Add(new RectangleF(rect.X + xsize, rect.Y, xsize, ysize));
                            nboxes.Add(new RectangleF(rect.X, rect.Y + ysize, xsize, ysize));
                            nboxes.Add(new RectangleF(rect.X + xsize, rect.Y + ysize, xsize, ysize));
                        }
                        boxes = nboxes;
                        ShowProgress(4, (int)xsize, "Size X");
                        ShowProgress(5, (int)ysize, "Size Y");
                    }

                    /* old land
                    g.Clear(Color.White);
                    for(int b = 0; b < normalland + bigLand + lakes; b++)
                    {
                        ShowProgress(3, b, normalland + bigLand + lakes, "Land creation");
                        int max = r.Next(30, 60);
                        int step = 30;
                        if (sx > 2000)
                            step = 15;
                        else if (sx > 1000)
                            step = 20;
                        if (b > bigLand)
                        {
                            max = r.Next(10, 20);
                            step = 3;
                            if (sx > 2000)
                                step = 1;
                            else if (sx > 1000)
                                step = 2;
                        }
                        

                        List<PointF> points = new List<PointF>();
                       
                        PointF startingpoint = new PointF(r.Next((int)(sx * 0.05f), (int)(sx * 0.95f)), r.Next((int)(sy * 0.05f), (int)(sy * 0.96f)));
                        points.Add(startingpoint);
                        int prevdist = 0;
                        for (int pol = 1; pol < max; pol++)
                        {
                            if (pol <= max / 2)
                            {
                                PointF p = new PointF(0, 0);
                                do {
                                    p = new PointF(points[points.Count - 1].X + r.Next(-(int)(sx * 0.01f * step), (int)(sx * 0.01f * step)), points[points.Count - 1].Y + r.Next(-(int)(sy * 0.01f * step), (int)(sy * 0.01f * step)));
                                }
                                while (!(p.X > sx * 0.04f && p.X < sx * 0.96f && p.Y > sy * 0.04f && p.Y < sy * 0.96f));
                                points.Add(p);
                            }
                            else
                            {
                                PointF np = new PointF(0, 0);
                                int dist = 0;
                                int ma = 0;
                                do
                                {
                                    np = new PointF(points[points.Count - 1].X + r.Next(-(int)(sx * 0.01f * step), (int)(sx * 0.01f * step)), points[points.Count - 1].Y + r.Next(-(int)(sy * 0.01f * step), (int)(sy * 0.01f * step)));
                                    dist = (int)Math.Sqrt(Math.Pow(Math.Abs(np.X - points[0].X), 2) + Math.Pow(Math.Abs(np.Y - points[0].Y), 2));
                                    ma++;
                                    if (ma > 40)
                                    {
                                        Console.WriteLine(dist + " " + prevdist + " | " + points[pol - 1].X + " " + points[pol - 1].Y);
                                        Console.ReadLine();
                                    }
                                }
                                while (dist > prevdist * 1.02f && prevdist > (int)(sx * 0.01f * step) && !(np.X > sx * 0.04f && np.X < sx * 0.96f && np.Y > sy * 0.04f && np.Y < sy * 0.96f));
                                if (np.X != 0 && np.Y != 0)
                                {
                                    points.Add(np);
                                    prevdist = dist;
                                }
                                if (dist < (int)(sx * 0.01f * step))
                                    break;
                                if (prevdist > sx * 0.01f * step && max < 1000)
                                    max += 1;
                            }
                        }    

                        //clear land
                        if(true || r.Next(0, 5) != 0)
                        {
                            float xsum = 0;
                            float ysum = 0;
                            foreach(PointF cen in points)
                            {
                                xsum += cen.X;
                                ysum += cen.Y;
                            }
                            PointF Center = new PointF(xsum / points.Count, ysum / points.Count);
                            Dictionary<PointF,double> angles = new Dictionary<PointF, double>();
                            points = points.Distinct().ToList();
                            foreach (PointF ang in points)
                            {
                                float xDiff = Center.X - ang.X;
                                float yDiff = Center.Y - ang.Y;
                                angles.Add(ang, Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI);
                            }
                            points = points.OrderBy(x => angles[x]).ToList();
                        }
                        if(b < normalland + bigLand)
                            g.DrawLines(Pens.Black, points.ToArray());                       
                        else
                            g.FillPolygon(Brushes.White, points.ToArray());
                    }     
                    */
                }
                LandMap.Save("sea.png");

                Bitmap riverbmp = new Bitmap(sx, sy);

                if (!onlySea)
                {
                    foreach (Province lp in provinces)
                    {

                        //Color c = Color.Black;
                        Color c = generateGoodColors(r);
                        if (lp != null && lp.points.Any())
                        {
                            if (LandMap.GetPixel(lp.points[0].x, lp.points[0].y) == Color.FromArgb(255, 255, 255, 255) || map[lp.points[0].y, lp.points[0].x] == -1 || !(lp.points[0].x > sx * 0.02f && lp.points[0].x < sx * 0.98f && lp.points[0].y > sy * 0.02f && lp.points[0].y < sy * 0.98f))
                            {
                                c = Color.White;
                                lp.seatile = true;
                            }                      
                            //Console.WriteLine(LandMap.GetPixel(lp[0].x, lp[0].y));
                            foreach (Point p in lp.points)
                            {
                                bmp.SetPixel(p.x, p.y, c);
                                if (!lp.seatile)
                                    riverbmp.SetPixel(p.x, p.y, Color.Black);
                            }
                        }
                    }
                    bmp.Save("img.png");
                    Console.WriteLine("Finished saving basic map");

                    //climate map

                    Bitmap ClimateMap = new Bitmap(sx, sy);
                    Bitmap ClimatProvinceMap = new Bitmap(sx + 1, sy + 1);

                    int polarline = (int)(sy * 0.01 * r.Next(0, 4));
                    int subpolarline = (int)(sy * 0.01 * r.Next(5, 8));
                    int temperateline = (int)(sy * 0.01 * r.Next(30, 45));
                    int subtropicalline = (int)(sy * 0.01 * r.Next(50, 60));
                    int tropicalline = (int)(sy * 0.01 * r.Next(65, 75));
                    int subtropical2line = (int)(sy * 0.01 * r.Next(80, 85));
                    int temperate2line = (int)(sy * 0.01 * r.Next(87, 93));
                    int subpolar2line = (int)(sy * 0.01 * r.Next(96, 99));

                    using (Graphics g = Graphics.FromImage(ClimateMap))
                    {
                        List<PointF> prevPoints = new List<PointF>();
                        for (int a = 0; a < 8; a++)
                        {
                            List<PointF> points = new List<PointF>();
                            prevPoints.Reverse();
                            points.AddRange(prevPoints);
                            prevPoints = new List<PointF>();
                            if (a == 0)
                            {
                                points.Add(new PointF(sx, 0));
                                points.Add(new PointF(0, 0));
                                prevPoints.Add(new PointF(0, 0));
                            }
                            Color c = Color.Black;
                            int min = 0;
                            int max = 0;

                            switch (a)
                            {
                                case 0:
                                    c = Color.LightCyan;
                                    min = 1;
                                    max = 5;
                                    break;
                                case 1:
                                    c = Color.LightBlue;
                                    min = 5;
                                    max = 12;
                                    break;
                                case 2:
                                    c = Color.LightGreen;
                                    min = 30;
                                    max = 45;
                                    break;
                                case 3:
                                    c = Color.Yellow;
                                    min = 50;
                                    max = 60;
                                    break;
                                case 4:
                                    min = 65;
                                    max = 75;
                                    c = Color.Orange;
                                    break;
                                case 5:
                                    min = 80;
                                    max = 85;
                                    c = Color.Yellow;
                                    break;
                                case 6:
                                    min = 87;
                                    max = 93;
                                    c = Color.LightGreen;
                                    break;
                                case 7:
                                    min = 96;
                                    max = 99;
                                    c = Color.LightBlue;
                                    break;
                            }
                            int current = 0;
                            do
                            {
                                PointF p = new PointF(current, sy * 0.001f * r.Next(min * 10, max * 10));
                                points.Add(p);
                                prevPoints.Add(p);
                                current += r.Next(sx / 50, sx / 40);
                            }
                            while (current < sy);
                            PointF last = new PointF(sx, sy * 0.001f * r.Next(min * 10, max * 10));
                            points.Add(last);
                            prevPoints.Add(last);
                            g.FillPolygon(new SolidBrush(c), points.ToArray());
                        }
                        List<PointF> LastLayer = new List<PointF>();
                        prevPoints.Reverse();
                        LastLayer.AddRange(prevPoints);
                        LastLayer.Add(new PointF(0, sy));
                        LastLayer.Add(new PointF(sx, sy));
                        g.FillPolygon(Brushes.LightCyan, LastLayer.ToArray());
                    }

                    foreach (Province lp in provinces)
                    {
                        if (lp != null && lp.points.Any())
                        {
                            if (bmp.GetPixel(lp.points[0].x, lp.points[0].y) != Color.FromArgb(255, 255, 255, 255))
                            {
                                Color col = ClimateMap.GetPixel(lp.points[0].x, lp.points[0].y);
                                lp.climate = col;
                                foreach (Point p in lp.points)
                                {
                                    ClimatProvinceMap.SetPixel(p.x, p.y, col);
                                }
                            }
                        }
                    }

                    ClimateMap.Save("climateall.png");
                    ClimatProvinceMap.Save("climate.png");
                    Console.WriteLine("Finished saving climate map");

                    foreach (Province lp in provinces)
                    {
                        if (lp != null && lp.points.Any())
                        {
                            lp.neighbours = new List<Province>();
                        }
                    }

                    Bitmap BorderingWater = new Bitmap(sx + 1, sy + 1);
                    if (!noBord)
                    {
                        //File.WriteAllText("neighbours.txt", "");
                        int nei = 0;
                        foreach (Province lp in provinces)
                        {
                            nei++;
                            if (lp == null && nei > 100)
                                break;
                            if (lp != null && lp.points.Any())
                            {
                                bool borderswater = false;
                                foreach (Point p in lp.points)
                                {
                                    int nid = map[p.y - 1, p.x];
                                    if (!lp.neighbours.Contains(provinces[nid]) && nid != lp.id)
                                    {
                                        lp.neighbours.Add(provinces[nid]);
                                        provinces[nid].neighbours.Add(lp);
                                    }
                                    if (!borderswater)
                                    {
                                        if (provinces[nid].seatile)
                                            borderswater = true;
                                    }
                                    nid = map[p.y + 1, p.x];
                                    if (!lp.neighbours.Contains(provinces[nid]) && nid != lp.id)
                                    {
                                        lp.neighbours.Add(provinces[nid]);
                                        provinces[nid].neighbours.Add(lp);
                                    }
                                    if (!borderswater)
                                    {
                                        if (provinces[nid].seatile)
                                            borderswater = true;
                                    }
                                    nid = map[p.y, p.x - 1];
                                    if (!lp.neighbours.Contains(provinces[nid]) && nid != lp.id)
                                    {
                                        lp.neighbours.Add(provinces[nid]);
                                        provinces[nid].neighbours.Add(lp);
                                    }
                                    if (!borderswater)
                                    {
                                        if (provinces[nid].seatile)
                                            borderswater = true;
                                    }
                                    nid = map[p.y, p.x + 1];
                                    if (!lp.neighbours.Contains(provinces[nid]) && nid != lp.id)
                                    {
                                        lp.neighbours.Add(provinces[nid]);
                                        provinces[nid].neighbours.Add(lp);
                                    }
                                    if (!borderswater)
                                    {
                                        if (provinces[nid].seatile)
                                            borderswater = true;
                                    }
                                }

                                if (borderswater)
                                {
                                    lp.borderingwater = true;
                                    if (!lp.seatile)
                                    {
                                        foreach (Point pbw in lp.points)
                                        {
                                            BorderingWater.SetPixel(pbw.x, pbw.y, Color.Blue);
                                        }
                                    }
                                }
                            }                            
                            if (nei % 500 == 0)
                                ShowProgress(8, nei, currentid, "Provinces done");
                        }
                        ShowProgress(8, currentid, currentid, "Provinces done");
                        BorderingWater.Save("borderingwater.png");
                        /*File.WriteAllText("neighbours.txt", "");
                        foreach(Province p in provinces)
                        {
                            string s = p.id + ":";
                            foreach (Province ng in p.neighbours)
                                s += ng.id + ",";
                            s = s.Remove(s.Length - 1, 1);
                            File.AppendAllText("neighbours.txt", s);
                        }
                        */
                    }
                    Console.WriteLine("Finished saving neighbours file");

                    Bitmap TerrainMap = new Bitmap(sx, sy);

                    Color[] tercol = new Color[] { Color.LightBlue, Color.DarkGreen, Color.Green, Color.Olive, Color.LightGoldenrodYellow, Color.Yellow, Color.Lime, Color.LightGreen, Color.Turquoise, Color.SandyBrown, Color.Brown, Color.YellowGreen, Color.RosyBrown };
                    string[] ter = new string[] { "Tundra", "Thick Forest", "Forest", "Jungle", "Savannah", "Desert", "Grasslands", "Flatlands", "Coastline", "Hills", "Mountains", "Steppe", "Marshes" };
                    int rp = 0;
                    while (rp < 20)
                    {

                        foreach (Province lp in provinces)
                        {

                            Color col = Color.Black;
                            if (lp != null && lp.points.Any())
                            {
                                int chan = 1;
                                if (!noBord)
                                {
                                    if (rp < 10)
                                        chan = 10 - rp;
                                    if (rp < 5)
                                    {
                                        foreach (Province neigh in lp.neighbours)
                                        {
                                            if (neigh != null && neigh.points.Any())
                                            {
                                                if (neigh.terrain != Color.FromArgb(0, 0, 0, 0))
                                                {
                                                    chan += 4;
                                                }
                                            }
                                        }
                                    }
                                }


                                if (!lp.seatile && lp.terrain == Color.FromArgb(0, 0, 0, 0) && r.Next(0, chan) == 0)
                                {
                                    col = lp.climate;
                                    //                               0             1            2         3          4         5            6            7            8          9          10          11
                                    int[] cha = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                    if (col == Color.FromArgb(255, Color.LightCyan))
                                    {
                                        cha[0] = 100;
                                        cha[1] = 25;
                                        cha[2] = 5;
                                        cha[9] = 5;
                                        cha[10] = 10;
                                    }
                                    else if (col == Color.FromArgb(255, Color.LightBlue))
                                    {
                                        cha[0] = 50;
                                        cha[1] = 100;
                                        cha[2] = 40;
                                        cha[9] = 10;
                                        cha[10] = 5;
                                        if (!noBord)
                                        {
                                            foreach (Province neigh in lp.neighbours)
                                            {
                                                if (neigh != null && neigh.points.Any())
                                                {
                                                    if (new List<Color> { Color.FromArgb(255, tercol[9]), Color.FromArgb(255, tercol[10]) }.Contains(neigh.terrain))
                                                    {
                                                        cha[9] += 200;
                                                        cha[10] += 200;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (col == Color.FromArgb(255, Color.LightGreen))
                                    {
                                        cha[1] = 10;
                                        cha[2] = 30;
                                        cha[5] = 1;
                                        cha[6] = 120;
                                        cha[7] = 120;
                                        cha[9] = 40;
                                        cha[10] = 20;
                                        cha[11] = 2;
                                        cha[12] = 45;
                                        if (!noBord)
                                        {
                                            if (lp.borderingwater)
                                                cha[8] = 200;
                                            foreach (Province neigh in lp.neighbours)
                                            {
                                                if (neigh != null && neigh.points.Any())
                                                {
                                                    if (neigh.terrain == Color.FromArgb(255, tercol[1]))
                                                        cha[1] += 10;
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[2]))
                                                        cha[2] += 50;
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[5]))
                                                        cha[5] += 30;
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[6]))
                                                    {
                                                        cha[6] += 60;
                                                        cha[9] -= 10;
                                                        cha[10] -= 80;
                                                    }
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[7]))
                                                    {
                                                        cha[7] += 40;
                                                        cha[9] -= 30;
                                                        cha[10] -= 140;
                                                    }
                                                    else if (new List<Color> { Color.FromArgb(255, tercol[9]), Color.FromArgb(255, tercol[10]) }.Contains(neigh.terrain))
                                                    {
                                                        cha[9] += 200;
                                                        cha[10] += 200;
                                                    }
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[11]))
                                                    {
                                                        cha[11] += 1200;
                                                        cha[6] -= 700;
                                                        cha[7] -= 500;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (col == Color.FromArgb(255, Color.Yellow))
                                    {
                                        cha[3] = 80;
                                        cha[4] = 120;
                                        cha[9] = 15;
                                        cha[10] = 15;
                                        if (!noBord)
                                        {
                                            if (lp.borderingwater)
                                                cha[8] = 200;
                                            foreach (Province neigh in lp.neighbours)
                                            {
                                                if (neigh != null && neigh.points.Any())
                                                {
                                                    if (neigh.terrain == Color.FromArgb(255, tercol[3]))
                                                    {
                                                        cha[3] += 300;
                                                        cha[4] -= 2000;
                                                    }
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[4]))
                                                    {
                                                        cha[4] += 300;
                                                        cha[3] -= 2000;
                                                    }
                                                    else if (new List<Color> { Color.FromArgb(255, tercol[9]), Color.FromArgb(255, tercol[10]) }.Contains(neigh.terrain))
                                                    {
                                                        cha[9] += 200;
                                                        cha[10] += 200;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (col == Color.FromArgb(255, Color.Orange))
                                    {
                                        cha[3] = 10;
                                        cha[4] = 10;
                                        cha[5] = 400;
                                        cha[9] = 5;
                                        cha[10] = 5;
                                        if (!noBord)
                                        {
                                            if (lp.borderingwater)
                                                cha[8] = 200;
                                            foreach (Province neigh in lp.neighbours)
                                            {
                                                if (neigh != null && neigh.points.Any())
                                                {
                                                    if (neigh.terrain == Color.FromArgb(255, tercol[3]))
                                                        cha[3] += 5;
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[4]))
                                                        cha[4] += 5;
                                                    else if (neigh.terrain == Color.FromArgb(255, tercol[5]))
                                                        cha[5] += 200;
                                                    else if (new List<Color> { Color.FromArgb(255, tercol[9]), Color.FromArgb(255, tercol[10]) }.Contains(neigh.terrain))
                                                    {
                                                        cha[9] += 200;
                                                        cha[10] += 200;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    col = RandomChoice(tercol, cha, r);
                                    lp.terrain = col;
                                    foreach (Point p in lp.points)
                                    {
                                        TerrainMap.SetPixel(p.x, p.y, col);
                                    }
                                }
                            }
                        }
                        rp++;
                        if (noBord)
                            break;
                        ShowProgress(10, rp, 20, "Terrain iterations");
                    }
                    ShowProgress(10, 20, 20, "Terrain iterations");

                    TerrainMap.Save("terrain.png");
                    Console.WriteLine("Finished saving terrain map");

                    bool rescont = true;
                    Bitmap ContinentsMap = new Bitmap(sx, sy);
                    List<List<Province>> Continents = new List<List<Province>>();
                    List<Province> Islands = new List<Province>();

                    //ShowProgress(20, neighbours[2].Count, "test");
                    int seatiles = provinces.Where(x => x.seatile).Count();
                    if (!noBord)
                    {
                        List<Province> provincesleft = new List<Province>(provinces);                   
                        while (rescont)
                        {
                            Province startprovince = provincesleft[0];
                            while (startprovince.seatile || Continents.Any(x => x.Contains(startprovince)) || Islands.Contains(startprovince))
                            {
                                provincesleft.Remove(provincesleft.First());
                                if (provincesleft.Any())
                                {
                                    startprovince = provincesleft[0];
                                }
                                else
                                {
                                    rescont = false;
                                    break;
                                }
                            }


                            List<Province> currentCont = new List<Province>() { };
                            List<Province> nextBatch = new List<Province>() { startprovince };
                            do
                            {
                                List<Province> toadd = new List<Province>();
                                foreach (Province n in nextBatch)
                                {
                                    currentCont.Add(n);
                                    toadd.AddRange(n.neighbours.Where(x => !(x.seatile || currentCont.Contains(x) || nextBatch.Contains(x) || toadd.Contains(x))));
                                }
                                nextBatch.Clear();
                                nextBatch.AddRange(toadd);
                            }
                            while (nextBatch.Any());

                            if (currentCont.Count > 1)
                            {
                                Continents.Add(currentCont);
                                provincesleft.RemoveAll(x => currentCont.Contains(x));
                            }
                            else if (currentCont.Count == 1)
                                Islands.Add(currentCont[0]);

                            ShowProgress(12, Continents.Count, "Continents");
                            ShowProgress(13, Continents.Sum(x => x.Count) + Islands.Count, currentid - seatiles, "Provinces in continents");

                        }

                        List<List<Province>> smll = new List<List<Province>>();
                        foreach (List<Province> co in Continents)
                        {
                            if (co.Count < 35)
                                smll.Add(co);
                        }
                        Continents.RemoveAll(x => smll.Contains(x));
                        foreach (Province isl in Islands)
                            smll.Add(new List<Province>() { isl });

                        Islands.Clear();
                        foreach (List<Province> smllco in smll)
                        {
                            foreach(Province p in smllco)
                            {
                                p.island = true;
                            }
                            List<int> candidatescores = new List<int>();
                            foreach (List<Province> candidate in Continents)
                            {
                                int score = 0;
                                if (smllco[0].points.Any())
                                {
                                    Point capitalsmll = smllco[0].points[0];
                                    int lowestdistance = sx + sy;
                                    foreach (Province provi in candidate)
                                    {
                                        if (provi.points.Any())
                                        {
                                            Point capitalbig = provi.points[0];
                                            int dist = (int)Math.Sqrt(Math.Pow(capitalbig.x - capitalsmll.x, 2) + Math.Pow(capitalbig.y - capitalsmll.y, 2));
                                            if (dist < lowestdistance)
                                                lowestdistance = dist;
                                        }
                                    }
                                    score += lowestdistance;
                                    score += (int)(0.000001 * sx * candidate.Count);
                                }
                                candidatescores.Add(score);
                            }
                            Continents[candidatescores.IndexOf(candidatescores.OrderBy(x => x).ToArray()[0])].AddRange(smllco);
                        }

                    }
                    foreach (List<Province> conti in Continents)
                    {
                        Color c = generateGoodColors(r);
                        foreach (Province pr in conti)
                        {
                            foreach (Point p in pr.points)
                            {
                                ContinentsMap.SetPixel(p.x, p.y, c);
                            }
                        }
                    }
                    ContinentsMap.Save("continents.png");
                    Console.WriteLine("Finished saving continents map");

                    //river map

                    
                    int nofpixriv = 0;

                    foreach(List<Province> continent in Continents)
                    {
                        int max = 1;
                        if (continent.Count < 80)
                            max = 1;
                        else if (continent.Count < 160)
                            max = 2;
                        else
                            max = 3;

                        for (int a = 0; a < max; a++)
                        {
                            Province p = null;
                            do
                                p = provinces[r.Next(0, provinces.Count)];
                            while (p.seatile || p.id == 0 || p.points.Count == 0 || p.borderingwater);
                            Point sp = p.points[r.Next(0, p.points.Count)];
                            p.hasriver = true;
                            int lastdir = 0;
                            int firstdir = 0;
                            bool oceanfound = false;
                            int l = 0;
                            do
                            {
                                l++;
                                riverbmp.SetPixel(sp.x, sp.y, Color.Blue);
                                int dir = 0;                                
                                int[] chanc = new int[] { 100, 100, 0, 100 };
                                switch (lastdir)
                                {
                                    case 0:
                                        chanc = new int[] { 1, 1, 1, 1 };
                                        break;
                                    case 1:
                                        chanc = new int[] { 100, 100, 0, 100 };
                                        break;
                                    case 2:
                                        chanc = new int[] { 100, 100, 100, 0 };
                                        break;
                                    case 3:
                                        chanc = new int[] { 0, 100, 100, 100 };
                                        break;
                                    case 4:
                                        chanc = new int[] { 100, 0, 100, 100 };
                                        break;
                                }

                                if (firstdir == 0)
                                    firstdir = dir;
                                else
                                {
                                    switch (firstdir)
                                    {
                                        case 1:
                                            chanc[2] -= 95;
                                            chanc[0] += 35;
                                            break;
                                        case 2:
                                            chanc[3] -= 95;
                                            chanc[1] += 35;
                                            break;
                                        case 3:
                                            chanc[0] -= 95;
                                            chanc[2] += 35;
                                            break;
                                        case 4:
                                            chanc[1] -= 95;
                                            chanc[3] += 35;
                                            break;
                                    }
                                }
                                Point np = null;
                                bool force = false;
                                int tries = 0;
                                do
                                {                              
                                    dir = RandomChoice(new int[] { 1, 2, 3, 4 }, chanc, r);
                                    switch (dir)
                                    {
                                        case 1:
                                            np = new Point(sp.x, sp.y - 1);
                                            break;
                                        case 2:
                                            np = new Point(sp.x + 1, sp.y);
                                            break;
                                        case 3:
                                            np = new Point(sp.x, sp.y + 1);
                                            break;
                                        case 4:
                                            np = new Point(sp.x - 1, sp.y);
                                            break;
                                    }
                                    tries++;
                                    if (tries > 10)
                                        force = true;
                                }
                                while ((CheckSurroundingPixels(np, ref riverbmp, Color.Blue) > 2 || CheckBorderingPixels(np, ref riverbmp, Color.Blue) > 1) && !force);
                                if (force)
                                    oceanfound = true;

                                sp = np;
                                lastdir = dir;
                                //Province pr = provinces.Find(x=>x.points.Any(y => y.x == sp.x && y.y == sp.y));
                                if (bmp.GetPixel(sp.x, sp.y) == Color.FromArgb(255, 255, 255, 255))
                                    oceanfound = true;
                                nofpixriv++;
                                ShowProgress(20, nofpixriv, "Pixels riv");
                            } while (!oceanfound);
                            if (l < 20)
                                max++;

                        }
                    }

                    riverbmp.Save("rivers.png");

                    foreach(Province p in provinces)
                    {
                        if (!p.seatile)
                        {
                            if (p.points.Any(x => riverbmp.GetPixel(x.x, x.y) == Color.FromArgb(255, Color.Blue)))
                                p.hasriver = true;
                        }
                    }
    
                    Bitmap ResourcesMap = new Bitmap(sx, sy);
                    List<Bitmap> vresources = new List<Bitmap>();
                    int done = 0;
                    int[] ResourceAmmount = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    string[] optionsstr = { "Wood", "Stone", "Copper", "Iron", "Gold", "Livestock", "Fish", "Grain", "Salt", "Nothing", "Clay", "Gems", "Fur" };
                    Color[] optionscol = { Color.Brown, Color.Gray, Color.DarkOrange, Color.DarkSlateGray, Color.Gold, Color.Coral, Color.Blue, Color.Wheat, Color.AntiqueWhite, Color.Black, Color.SaddleBrown, Color.Aquamarine, Color.Bisque };
                    foreach(string s in optionsstr)
                    {
                        vresources.Add(new Bitmap(sx, sy));
                    }

                    foreach (Province province in provinces)
                    {
                        if (done > currentid)
                            break;
                        Dictionary<string, int> optionsint = new Dictionary<string, int>{ { "Wood", 0 }, { "Stone", 0 }, { "Copper", 0 }, { "Iron", 0 }, { "Gold", 0 }, { "Livestock", 0 }, { "Fish", 0 }, { "Grain", 0 }, { "Salt", 0 }, { "Nothing", 0 }, { "Clay", 0 }, { "Gems", 0 }, { "Fur", 0 } };
                        bool water = false;
                        if (province.points.Any())
                        {
                            Color co = province.terrain;
                            optionsint["Nothing"] = 1000;
                            //tundra
                            if (co == tercol[0])
                            {
                                optionsint["Wood"] = 15;
                                optionsint["Stone"] = 25;
                                optionsint["Copper"] = 2;
                                optionsint["Iron"] = 2;
                                optionsint["Gold"] = 1;
                                optionsint["Fish"] = 35;
                                optionsint["Salt"] = 2;
                                optionsint["Gems"] = 1;

                            }
                            //thick forest
                            else if (co == tercol[1])
                            {
                                optionsint["Wood"] = 350;
                                optionsint["Stone"] = 5;
                                optionsint["Copper"] = 2;
                                optionsint["Iron"] = 2;
                                optionsint["Gold"] = 1;
                                optionsint["Salt"] = 1;
                                optionsint["Clay"] = 5;
                                optionsint["Gems"] = 1;
                                optionsint["Fur"] = 70;

                            }
                            //forest
                            else if (co == tercol[2])
                            {
                                optionsint["Wood"] = 250;
                                optionsint["Stone"] = 10;
                                optionsint["Copper"] = 3;
                                optionsint["Iron"] = 2;
                                optionsint["Gold"] = 1;
                                optionsint["Salt"] = 2;
                                optionsint["Clay"] = 8;
                                optionsint["Gems"] = 1;
                                optionsint["Fur"] = 75;
                            }
                            //jungle
                            else if (co == tercol[3])
                            {
                                optionsint["Wood"] = 400;
                                optionsint["Stone"] = 10;
                                optionsint["Copper"] = 3;
                                optionsint["Iron"] = 3;
                                optionsint["Gold"] = 1;
                                optionsint["Fish"] = 2;
                                optionsint["Salt"] = 2;
                                optionsint["Clay"] = 10;
                                optionsint["Gems"] = 1;
                                optionsint["Fur"] = 30;
                            }
                            //savannah
                            else if (co == tercol[4])
                            {
                                optionsint["Wood"] = 60;
                                optionsint["Stone"] = 15;
                                optionsint["Copper"] = 6;
                                optionsint["Iron"] = 4;
                                optionsint["Gold"] = 2;
                                optionsint["Livestock"] = 15;
                                optionsint["Grain"] = 25;
                                optionsint["Salt"] = 3;
                                optionsint["Clay"] = 15;
                                optionsint["Gems"] = 2;
                                optionsint["Fur"] = 5;
                            }
                            //desert
                            else if (co == tercol[5])
                            {
                                optionsint["Stone"] = 5;
                                optionsint["Copper"] = 2;
                                optionsint["Iron"] = 2;
                                optionsint["Gold"] = 1;
                                optionsint["Livestock"] = 2;
                                optionsint["Salt"] = 2;
                                optionsint["Gems"] = 2;
                            }
                            //grasslands
                            else if (co == tercol[6])
                            {
                                optionsint["Wood"] = 35;
                                optionsint["Stone"] = 20;
                                optionsint["Copper"] = 6;
                                optionsint["Iron"] = 5;
                                optionsint["Gold"] = 2;
                                optionsint["Livestock"] = 50;
                                optionsint["Fish"] = 5;
                                optionsint["Grain"] = 55;
                                optionsint["Salt"] = 6;
                                optionsint["Clay"] = 15;
                                optionsint["Gems"] = 3;
                                optionsint["Fur"] = 3;
                            }
                            //flatlands
                            else if (co == tercol[7])
                            {
                                optionsint["Wood"] = 25;
                                optionsint["Stone"] = 25;
                                optionsint["Copper"] = 6;
                                optionsint["Iron"] = 5;
                                optionsint["Gold"] = 2;
                                optionsint["Livestock"] = 25;
                                optionsint["Fish"] = 5;
                                optionsint["Grain"] = 40;
                                optionsint["Salt"] = 4;
                                optionsint["Clay"] = 25;
                                optionsint["Gems"] = 2;
                                optionsint["Fur"] = 3;
                            }
                            //coast
                            else if (co == tercol[8])
                            {
                                optionsint["Wood"] = 5;
                                optionsint["Stone"] = 10;
                                optionsint["Copper"] = 4;
                                optionsint["Iron"] = 4;
                                optionsint["Gold"] = 2;
                                optionsint["Livestock"] = 20;
                                optionsint["Fish"] = 150;
                                optionsint["Grain"] = 15;
                                optionsint["Salt"] = 25;
                                optionsint["Clay"] = 25;
                                optionsint["Gems"] = 3;
                            }
                            //hills
                            else if (co == tercol[9])
                            {
                                optionsint["Wood"] = 20;
                                optionsint["Stone"] = 80;
                                optionsint["Copper"] = 10;
                                optionsint["Iron"] = 8;
                                optionsint["Gold"] = 3;
                                optionsint["Livestock"] = 25;
                                optionsint["Grain"] = 15;
                                optionsint["Salt"] = 6;
                                optionsint["Clay"] = 5;
                                optionsint["Gems"] = 4;
                            }
                            //mountains
                            else if (co == tercol[10])
                            {
                                optionsint["Wood"] = 10;
                                optionsint["Stone"] = 100;
                                optionsint["Copper"] = 12;
                                optionsint["Iron"] = 10;
                                optionsint["Gold"] = 4;
                                optionsint["Livestock"] = 20;
                                optionsint["Grain"] = 5;
                                optionsint["Salt"] = 8;
                                optionsint["Clay"] = 5;
                                optionsint["Gems"] = 5;
                            }
                            //steppe
                            else if (co == tercol[11])
                            {
                                optionsint["Wood"] = 10;
                                optionsint["Stone"] = 5;
                                optionsint["Copper"] = 3;
                                optionsint["Iron"] = 3;
                                optionsint["Gold"] = 1;
                                optionsint["Livestock"] = 70;
                                optionsint["Fish"] = 5;
                                optionsint["Grain"] = 10;
                                optionsint["Salt"] = 3;
                                optionsint["Clay"] = 8;
                                optionsint["Gems"] = 2;
                                optionsint["Fur"] = 30;
                            }
                            //marshes
                            else if (co == tercol[12])
                            {
                                optionsint["Wood"] = 100;
                                optionsint["Stone"] = 15;
                                optionsint["Copper"] = 7;
                                optionsint["Iron"] = 7;
                                optionsint["Gold"] = 3;
                                optionsint["Livestock"] = 10;
                                optionsint["Fish"] = 10;
                                optionsint["Grain"] = 5;
                                optionsint["Salt"] = 5;
                                optionsint["Clay"] = 100;
                                optionsint["Gems"] = 2;
                                optionsint["Fur"] = 3;
                            }
                            else
                                water = true;
                            if (r.Next(0, 25) == 1)
                                optionsint[RandomChoice(new string[] { "Copper", "Iron", "Gold", "Salt", "Gems" }, new int[] { 20, 20, 12, 15, 12 }, r)] += 35;
                            if (r.Next(0, 120) == 1)
                                optionsint[RandomChoice(new string[] { "Copper", "Iron", "Gold", "Salt", "Gems" }, new int[] { 20, 20, 12, 15, 12 }, r)] += 120;
                            if (r.Next(0, 350) == 1)
                                optionsint[RandomChoice(new string[] { "Copper", "Iron", "Gold", "Salt", "Gems" }, new int[] { 20, 20, 12, 15, 12 }, r)] += 350;
                            if (province.borderingwater && co != Color.FromArgb(255, tercol[8]))
                                optionsint["Fish"] += 65;
                            if (province.hasriver)
                            {
                                optionsint["Fish"] += 75;
                                optionsint["Grain"] += 65;
                                optionsint["Livestock"] += 55;
                            }

                            optionsint["Nothing"] -= optionsint["Wood"] + optionsint["Stone"] + optionsint["Copper"] + optionsint["Iron"] + optionsint["Gold"] + optionsint["Livestock"] + optionsint["Fish"] + optionsint["Grain"] + optionsint["Salt"] + optionsint["Clay"] + optionsint["Gems"] + optionsint["Fur"];
                            foreach (Point pix in province.points)
                            {
                                if (!water)
                                {
                                    Color opt = RandomChoice(optionscol, optionsint.Values.ToArray(), r);
                                    ResourcesMap.SetPixel(pix.x, pix.y, opt);
                                    province.resources.Add(pix, opt);
                                    ResourceAmmount[optionscol.ToList().IndexOf(opt)]++;
                                    foreach (Bitmap bp in vresources)
                                        bp.SetPixel(pix.x, pix.y, Color.Black);
                                    vresources[optionscol.ToList().IndexOf(opt)].SetPixel(pix.x, pix.y, opt);
                                }
                                else
                                    ResourcesMap.SetPixel(pix.x, pix.y, Color.White);
                            }
                        }
                        done++;
                        if (done % 50 == 0)
                            ShowProgress(14, done, -1, "Resources");
                    }
                    ShowProgress(14, done, -1, "Resources");
                    int maxp = provinces.Count - seatiles;
                    Console.WriteLine("Finished saving resources map");
                    for (int resw = 0; resw < 11; resw++)
                    {
                        Console.WriteLine(optionsstr[resw] + ":" + ResourceAmmount[resw] + "   |   Average: " + ResourceAmmount[resw] / (float)maxp);
                    }
                    ResourcesMap.Save("resources.png");
                    foreach (Bitmap bp in vresources)
                        bp.Save("resources/" + optionsstr[vresources.IndexOf(bp)].ToLower() + ".png");


                    //regions
                    Bitmap regionsb = new Bitmap(sx, sy);
                    List<Region> regions = new List<Region>();
                    Region curreg = new Region();
                    float curregfirstdistance = 0;
                    List<Province> provincesleftreg = new List<Province>(provinces.Where(x=>!x.seatile));
                    Dictionary<Province, float> currcandidates = new Dictionary<Province, float>();
                    bool forceend = false;                   
                    do
                    {
                        if (((curreg.provinces.Count > 6) && (curreg.provinces.Count > 12 || r.Next(0, 3) == 0)) || forceend)
                        {
                            regions.Add(curreg);
                            curreg = new Region();
                            currcandidates.Clear();
                            curregfirstdistance = 0;
                            ShowProgress(27, regions.Count, "Regions");
                        }
                        if (!curreg.provinces.Any())
                        {
                            Province pr = provincesleftreg[0];
                            provincesleftreg.Remove(pr);
                            curreg.provinces.Add(pr);
                        }  
                        
                        foreach(Province pr in curreg.provinces)
                        {
                            foreach(Province prnei in pr.neighbours)
                            {
                                if (provincesleftreg.Contains(prnei) && !curreg.provinces.Contains(prnei) && !currcandidates.Keys.Contains(prnei))
                                    currcandidates.Add(prnei, 0);
                            }
                        }
                        //Console.WriteLine("test1");

                        foreach (Province p in curreg.provinces)
                        {
                            if (currcandidates.Keys.Contains(p))
                                currcandidates.Remove(p);
                        }
                        forceend = false;
                        if (currcandidates.Any())
                        {
                            if (currcandidates.Count == 1)
                            {
                                Province provv = currcandidates.Keys.ToList()[0];
                                curreg.provinces.Add(provv);
                                provincesleftreg.Remove(provv);
                            }
                            else
                            {
                                List<Province> currcandloop = new List<Province>(currcandidates.Keys.ToList());
                                foreach(Province key in currcandloop)
                                { 
                                    currcandidates[key] = 0;
                                    bool f = false;
                                    foreach (Province n in curreg.provinces)
                                    {                                       
                                        if (n.points.Any() && key.points.Any())
                                        {
                                            float m = 0.01f;
                                            if (key.terrain == n.terrain)
                                                m /= 0.5f;
                                            if (!f)
                                            {
                                                float dis = distProvinces(n, key) * m;
                                                currcandidates[key] += dis * dis;
                                            }
                                            else
                                            {                                               
                                                currcandidates[key] += distProvinces(n, key) * m;
                                            }
                                        }
                                    }                                    
                                }
                                currcandidates = currcandidates.Where(x=>x.Key.points.Any()).OrderBy(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);
                                Province ch = null;
                                if (currcandidates.Count > 1)
                                   ch = RandomChoice(new Province[] { currcandidates.Keys.ToList()[0], currcandidates.Keys.ToList()[1] }, new int[] { 50, 1 }, r);
                                else
                                    ch = currcandidates.Keys.ToArray()[0];
                                if (ch != null)
                                {
                                    if (curregfirstdistance == 0)
                                        curregfirstdistance = currcandidates[ch];
                                    else if (currcandidates[ch] > 1.5f * curregfirstdistance)
                                        forceend = true;
                                    curreg.provinces.Add(ch);
                                    currcandidates.Remove(ch);
                                    provincesleftreg.Remove(ch);
                                }
                            }
                        }
                        else
                            forceend = true;
                        //Console.WriteLine("test2");


                    } while (provincesleftreg.Any());

                    Console.WriteLine("Completed normal region");

                    List<Province> smlreg = new List<Province>();
                    List<Region> toremove = new List<Region>();
                    foreach(Region rg in regions)
                    {
                        if(rg.provinces.Count < 3)
                        {
                            toremove.Add(rg);
                            rg.provinces.ForEach(x => smlreg.Add(x));
                        }
                    }
                    regions.RemoveAll(x => toremove.Contains(x));                    
                    List<Province> torm = new List<Province>();
                    int coun = 0;
                    do
                    {
                        coun++;
                        smlreg.RemoveAll(x => torm.Contains(x));
                        torm.Clear();
                        foreach(Province s in smlreg)
                        {
                            List<Region> cand = new List<Region>();
                            foreach(Province ng in s.neighbours)
                            {
                                cand.Add(regions.Find(x => x.provinces.Contains(ng)));
                            }
                            cand = cand.Where(x => x != null).ToList();
                            if (cand.Any())
                            {
                                cand[r.Next(0, cand.Count)].provinces.Add(s);
                                torm.Add(s);
                            }                           
                        }                    
                    } while (smlreg.Any() && coun < 8);

                    smlreg = smlreg.Where(x => x.points.Any()).ToList();
                    foreach(Province p in smlreg)
                    {
                        Dictionary<Region, int> cand = new Dictionary<Region, int>();
                        foreach(Region rr in regions)
                        {
                            cand.Add(rr,distProvinces(rr.provinces[0], p));
                        }
                        cand = cand.OrderBy(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);
                        cand.Keys.ToArray()[0].provinces.Add(p);
                    }
                    
                    foreach(Region region in regions)
                    {
                        Color cl = generateGoodColors(r);
                        foreach(Province p in region.provinces)
                        {
                            foreach(Point pix in p.points)
                            {
                                regionsb.SetPixel(pix.x, pix.y, cl);
                            }
                        }
                    }
                    regionsb.Save("regions.png");
                    //make so that regions with 1 province don't exist!!!!
                }
            }
            while (true);
        }

        static void ShowProgress(int y, int current, string message)
        {
            ShowProgress(y, current, -1, message);
        }

        static int CheckSurroundingPixels(Point p, ref Bitmap bmp, Color c)
        {
            int sum = 0;
            if (bmp.GetPixel(p.x - 1, p.y - 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x, p.y - 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x + 1, p.y + 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x - 1, p.y) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x + 1, p.y) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x - 1, p.y + 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x, p.y + 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x + 1, p.y + 1) == Color.FromArgb(255, c))
                sum++;
            return sum;
        }

        static int CheckBorderingPixels(Point p, ref Bitmap bmp, Color c)
        {
            int sum = 0;
            if (bmp.GetPixel(p.x, p.y - 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x, p.y + 1) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x - 1, p.y) == Color.FromArgb(255, c))
                sum++;
            if (bmp.GetPixel(p.x + 1, p.y) == Color.FromArgb(255, c))
                sum++;           
            return sum;
        }

        static void ShowProgress(int y, int current, int max, string message)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("                                        ");
            Console.SetCursorPosition(0, y);
            if (max < current)
                Console.Write(message + ": " + current);
            else
                Console.Write(message + ": " + current + " / " + max);
            Console.SetCursorPosition(0, y + 1);
        }

        static int distProvinces(Province p1, Province p2)
        {
            if (p1.id == 0 || p2.id == 0)
                return 999999999;
            else
                return (int)Math.Sqrt(Math.Pow(p1.points[0].x - p2.points[0].x, 2) + Math.Pow(p1.points[0].y - p2.points[0].y, 2));
        }

        static Color generateGoodColors(Random r)
        {
            int red, green, blue, sum = 0;
            do
            {
                red = r.Next(0, 256);
                green = r.Next(0, 256);
                blue = r.Next(0, 256);
                sum = red + green + blue;
            } while (sum < 65 || sum > 700);
            return Color.FromArgb(255, red, green, blue);
        }

        public static class LanguageClass
        {
            //english
            static string[] ensyllables = new string[] { "AL", "AN", "AR", "AS", "AT", "EA", "ED", "EN", "ER", "ES", "HA", "HA", "HI", "IN", "IS", "IT", "LE", "ME", "ND", "NE", "NG", "NT", "ON", "OR", "OU", "RE", "SE", "ST", "TE", "TH", "TI", "TO", "VE", "WA", "ALL", "AND", "ARE", "BUT", "ENT", "ERA", "ERE", "EVE", "FOR", "HAD", "HAT", "HEN", "HER", "HIN", "HIS", "ING", "ION", "ITH", "NOT", "OME", "OUL", "OUR", "SHO", "TED", "TER", "THA", "THE", "THI", "TIO", "ULD", "VER", "WAS", "WIT", "YOU" };

            //swedish
            static string[] scsyllables = new string[] { "AD", "AN", "AR", "ÄR", "AT", "CH", "DE", "EN", "ER", "ET", "FÖ", "GE", "HA", "IG", "IN", "KA", "LA", "LI", "LL", "ME", "NA", "ND", "NG", "OC", "OM", "OR", "ÖR", "RA", "RE", "SK", "ST", "TA", "TE", "TI", "TT", "VA", "ADE", "ALL", "AND", "ANS", "ARA", "ATT", "DEN", "DER", "DET", "ERA", "ETT", "FÖR", "GEN", "HAN", "ILL", "ING", "INT", "JAG", "KAN", "LIG", "LLA", "LLE", "MED", "MEN", "NDE", "NGE", "NIN", "NNE", "NTE", "OCH", "SAM", "SOM", "STA", "STE", "TER", "TIL", "TTA", "VAR", "VER" };

            //nahuatl
            static string[] nhvowels = new string[] { "a", "e", "i", "o" };
            static string[] nhsyllables = new string[] { "ma", "me", "mi", "mo", "m", "na", "ne", "ni", "no", "n", "pa", "pe", "pi", "po", "p", "ta", "te", "ti", "to", "t", "ka", "ke", "ki", "ko", "k", "kwa", "kwe", "kwi", "kwo", "kw", "tsa", "tse", "tsi", "tso", "ts", "tla", "tle", "tli", "tlo", "cha", "che", "chi", "cho", "sa", "se", "si", "so", "s", "la", "le", "li", "lo", "l", "xa", "xe", "xi", "xo", "x", "ya", "ye", "yi", "yo", "y", "ra", "re", "ri", "ro", "r", "h", "w" };

            //polish
            static string[] plsyllables = new string[] { "AN", "AŁ", "BY", "CH", "CI", "CZ", "DO", "DZ", "ER", "IA", "IE", "JE", "KO", "NA", "NI", "ON", "OW", "PO", "PR", "RA", "RO", "RZ", "ST", "SZ", "TA", "WI", "ZA", "ZE", "ZI", "ZY", "ACH", "ALE", "ANI", "BYŁ", "CIE", "CZE", "CZY", "DZI", "EGO", "ENI", "ERA", "EST", "IAŁ", "IED", "IEJ", "JAK", "JES", "KIE", "NIA", "NIE", "OST", "OWA", "OWI", "POW", "PRZ", "RZE", "RZY", "ŚCI", "SIĘ", "STA", "WIE", "YCH", "ZIE" };

            //mongol
            static string[] mnsyllables = new string[] { "AA", "AG", "AJ", "AL", "AN", "AR", "BA", "BO", "GA", "GE", "DA", "DE", "IJ", "JN", "LA", "ND", "OL", "ON", "OR", "SA", "TA", "UL", "UU", "HA", "HE", "YN", "EG", "EL", "EN", "ER", "EE", "ҮҮ", "AAN", "AAR", "AGA", "AJN", "ARA", "BAJ", "BOL", "GAA", "GIJ", "GOL", "GEE", "GҮJ", "DAA", "DEE", "ZEE", "IJG", "IJN", "LAG", "LIJ", "LYN", "MON", "NGO", "NIJ", "OLO", "ONG", "RÈG", "SAN", "SON", "SÈN", "TAJ", "ULA", "ULS", "HIJ", "ERE", "EER" };

            //french
            static string[] frsyllables = new string[] { "AI", "AN", "AR", "AU", "CE", "CH", "CO", "DE", "EM", "EN", "ER", "ES", "ET", "EU", "IE", "IL", "IN", "IS", "IT", "LA", "LE", "MA", "ME", "NE", "NS", "NT", "ON", "OU", "PA", "QU", "RA", "RE", "SE", "TE", "TI", "TR", "UE", "UN", "UR", "US", "VE", "AIN", "AIS", "AIT", "ANS", "ANT", "ATI", "AVA", "AVE", "CHA", "CHE", "COM", "CON", "DAN", "DES", "ELL", "EME", "ENT", "EST", "ÉTA", "EUR", "EUX", "FAI", "IEN", "ION", "IRE", "LES", "LLE", "LUS", "MAI", "MEN", "MME", "NTE", "OMM", "ONT", "OUR", "OUS", "OUT", "OUV", "PAR", "PAS", "PLU", "POU", "QUE", "RES", "SON", "SUR", "TAI", "TIO", "TOU", "TRE", "UNE", "URE", "VER", "VOU" };

            //italian
            static string[] itsyllables = new string[] { "AL", "AN", "AR", "AT", "CA", "CH", "CO", "DE", "DI", "EL", "EN", "ER", "ES", "HE", "IA", "IL", "IN", "IO", "LA", "LE", "LI", "LL", "MA", "ME", "NA", "NE", "NO", "NT", "OL", "ON", "OR", "PE", "RA", "RE", "RI", "RO", "SE", "SI", "SO", "ST", "TA", "TE", "TI", "TO", "TR", "TT", "UN", "ALE", "ALL", "ANC", "AND", "ANT", "ARE", "ATO", "ATT", "CHE", "CHI", "COM", "CON", "DEL", "ELL", "ENT", "ERA", "ERE", "ESS", "EST", "ETT", "GLI", "ION", "LLA", "MEN", "NON", "NTE", "NTI", "NTO", "OLO", "ONE", "ONO", "PER", "QUE", "SON", "STA", "STO", "TAT", "TRA", "TTO", "UNA", "VER", "ZIO" };

            //latin
            static string[] lasyllables = new string[] { "AE", "AM", "AN", "AR", "AT", "CI", "CO", "DE", "DI", "EM", "EN", "ER", "ES", "ET", "IA", "IN", "IS", "IT", "IU", "LI", "NE", "NI", "NT", "ON", "OR", "OS", "PE", "QU", "RA", "RE", "RI", "RU", "SE", "SI", "ST", "TA", "TE", "TI", "TU", "UE", "UI", "UM", "UR", "US", "ANT", "ATI", "ATU", "BUS", "CON", "CUM", "ENT", "ERA", "ERE", "ERI", "EST", "IAM", "IBU", "ILI", "ISS", "ITA", "ITU", "IUM", "IUS", "NTE", "NTI", "ORU", "PER", "PRO", "QUA", "QUE", "QUI", "QUO", "RAT", "RUM", "SSE", "TAT", "TER", "TIS", "TUM", "TUR", "TUS", "UNT" };

            //spain
            static string[] essyllables = new string[] { "AD", "AL", "AN", "AR", "AS", "CI", "CO", "DE", "DO", "EL", "EN", "ER", "ES", "IE", "IN", "LA", "LO", "ME", "NA", "NO", "NT", "ON", "OR", "OS", "PA", "QU", "RA", "RE", "RO", "SE", "ST", "TA", "TE", "TO", "UE", "UN", "ACI", "ADA", "ADO", "ANT", "ARA", "CIÓ", "COM", "CON", "DES", "DOS", "ENT", "ERA", "ERO", "EST", "IDO", "IEN", "IER", "IÓN", "LAS", "LOS", "MEN", "NTE", "NTO", "PAR", "PER", "POR", "QUE", "RES", "STA", "STE", "TEN", "TRA", "UNA", "VER" };
            //russian
            static string[] rusyllables = new string[] { "AL", "AN", "BY", "VE", "VO", "GO", "DE", "EL", "EN", "ER", "ET", "KA", "KO", "LA", "LI", "LO", "LY", "NA", "NE", "NI", "NO", "OV", "OL", "ON", "OR", "OS", "OT", "PO", "PR", "RA", "RE", "RO", "ST", "TA", "TE", "TO", "TY", "ATY", "BYL", "VER", "EGO", "ENI", "ENN", "EST", "KAK", "LYN", "OVA", "OGO", "OLY", "ORO", "OST", "OTO", "PRI", "PRO", "STA", "STV", "TOR", "ČTO", "ÈTO" };

            //chinese
            static string[] zhsyllables = new string[] {"er","ai","ao","ou","an","en","ang","eng","yi","ya","yao","ye","you","yan","yin","yang","ying","yong","wu","wa","wo","wai","wei","wan","wen","wang","weng","yu","yue","yuan","yun","ba","bo","bai","bei","bao","ban","bang","beng","ben","bi","biao","bie","bian","bin","bing","bu","pa","po","pai","pei","pao","pou","pan","pen","pang","peng","piao","pi","pie","pin","ping","pu","ma","mo","me","mai","mei","mao","mou","man","men","mang","meng","pian","mi","miao","mie","miu","mian","min","ming","mu","fa","fo","fei",
            "fou","fan","fen","fang","feng","ding","fu","da","de","dai","dei","dao","dou","dan","den","dang","deng","dong","di","diao","die","diu","dian","du","duo","dui","duan","dun","ta","te","tai","tei","tao","tou","tan","tang","teng","tong","ti","tiao","tie","tian","ting","tu","tuo","tui","tuan","tun","na","ne","nai","nei","nao","nou","nan","nen","nang","neng","nong","ni","niao","nie","niu","nian","nin","niang","ning","nu","nuo","nuan","nü","nüe","la","le","lai","lei","lao","lou","lan","lang","leng","long","li","lia","liao","lie","liu","lian","lin",
            "liang","ling","lu","luo","luan","lun","lü","lüe","ga","ge","gai","gei","gao","gou","gan","gen","gang","geng","gong","gu","gua","guo","guai","gui","guan","gun","guang","ka","ke","kai","kei","kao","kou","kan","ken","kang","keng","kong","ku","kua","kuo","kuai","kui","kuan","kun","kuang","ha","he","hai","hei","hao","hou","han","hen","hang","heng","hong","hu","hua","huo","huai","hui","huan","hun","huang","za","ze","zi","zai","zei","zao","zou","zan","zen","zang","zeng","zong","zu","zuo","zui","zuan","zun","ca","ce","ci","cai","cao","cou","can","cen",
            "cang","ceng","cong","cu","cuo","cui","cuan","cun","sa","se","si","sai","sao","sou","san","sen","sang","seng","song","su","suo","sui","suan","sun","zha","zhe","zhi","zhai","zhei","zhao","zhou","zhan","zhen","zhang","zheng","zhong","zhu","zhua","zhuo","zhuai","zhui","zhuan","zhun","zhuang","cha","che","chi","chai","chao","chou","chan","chen","chang","cheng","chong","chu","chua","chuo","chuai","chui","chuan","chun","chuang","sha","she","shi","shai","shei","shao","shou","shan","shen","shang","sheng","shu","shua","shuo","shuai","shui","shuan","shun",
            "shuang","re","ri","rao","rou","ran","ren","rang","reng","rong","ru","rua","ruo","rui","ruan","run","ji","jia","jiao","jie","jiu","jian","jin","jiang","jing","jiong","ju","jue","juan","jun","qi","qia","qiao","qie","qiu","qian","qi","qiang","qing","qiong","qu","que","quan","qun","xi","xia","xiao","xie","xiu","xian","xi","xiang","xing","xiong","xu","xue","xuan","xun"};

            //german
            static string[] desyllables = new string[] { "AN", "AU", "BE", "CH", "DA", "DE", "DI", "EI", "EL", "EN", "ER", "ES", "GE", "HE", "HT", "IC", "IE", "IN", "IT", "LE", "LI", "ND", "NE", "NG", "RE", "SC", "SE", "SI", "ST", "TE", "UN", "ABE", "ACH", "AND", "AUF", "AUS", "BEN", "BER", "CHE", "CHT", "DAS", "DEN", "DER", "DIE", "EIN", "EIT", "END", "ERE", "ERS", "ESE", "GEN", "HEN", "ICH", "IGE", "INE", "IST", "LIC", "LLE", "MEN", "MIT", "NDE", "NEN", "NGE", "NIC", "NTE", "REN", "SCH", "SEI", "SEN", "SIC", "SIE", "STE", "TEN", "TER", "UND", "UNG", "VER" };

            //dutch
            static string[] ndsyllables = new string[] { "AA", "AL", "AN", "AR", "AT", "BE", "CH", "DA", "DE", "EE", "EL", "EN", "ER", "ET", "GE", "HE", "IE", "IJ", "IN", "KE", "LE", "ME", "ND", "NG", "OE", "ON", "OO", "OR", "RE", "ST", "TE", "VA", "VE", "WA", "ZE", "AAN", "AAR", "ACH", "ALS", "AND", "CHT", "DAT", "DEN", "DER", "EDE", "EEN", "EER", "ELĲ", "END", "ERD", "ERE", "ERS", "GEN", "HAA", "HET", "IET", "ING", "KEN", "LLE", "LIJK", "MAA", "MEN", "MET", "NDE", "NEN", "NGE", "NIE", "OND", "OOR", "RDE", "REN", "SCH", "STE", "TEN", "TER", "UIT", "VAN", "VER", "VOO", "WAS", "ZIJN" };

            //greek
            static string[] grsyllables = new string[] { "AI", "AN", "AP", "AS", "Í", "I", "IS", "IA", "IK", "KA", "MA", "ME", "NA", "I", "PO", "RA", "RO", "SE", "ST", "TA", "TE", "TI", "TI", "TO", "APÓ", "AIT", "YIA", "DEN", "ÍN", "ÍKh", "ÉNA", "ÍTA", "ÍNA", "KAI", "MÉN", "NAI", "DA", "IS", "PI", "PRO", "SI", "STI", "STO", "TAI", "TAN", "TIN", "TIS", "TIK", "TI" };

            //japanese
            static string[] jpvowels = new string[] { "a", "e", "i", "o", "u" };
            static string[] jpconsonants = new string[] { };


            public static void InitialiseLanguagePack()
            {
                string[] conststart = new string[] { "k", "s", "t", "n", "h", "m", "r", "g", "z", "d", "p", "b" };
                List<string> toAdd = new List<string>();
                toAdd.AddRange(new string[] { "yu", "ya", "yo", "wa", "wo", "n", "kya", "kyu", "kyo", "sha", "shu", "sho", "cha", "chu", "cho", "nya", "nyu", "nyo", "hya", "hyu", "hyo", "mya", "myu", "myo", "rya", "ryu", "ryo", "gya", "gyu", "gyo", "ja", "ju", "jo", "bya", "byu", "byo", "pya", "pyu", "pyo" });
                foreach (string cons in conststart)
                {
                    foreach (string vo in jpvowels)
                    {
                        if (cons == "s" && vo == "i")
                            toAdd.Add("shi");
                        else if (cons == "t" && vo == "i")
                            toAdd.Add("chi");
                        else if (cons == "t" && vo == "u")
                            toAdd.Add("tsu");
                        else if (cons == "h" && vo == "u")
                            toAdd.Add("fu");
                        else if (cons == "z" && vo == "i")
                            toAdd.Add("ji");
                        else if (cons == "d" && vo == "i")
                            ;
                        else if (cons == "d" && vo == "u")
                            ;
                        else
                            toAdd.Add(cons + vo);
                    }
                }
                jpconsonants = toAdd.ToArray();
            }

            public enum Language { en, jp, de, zh, sc, pl, ru, nh, mn, fr, it, la, es, nd, gr };

            public static string GenerateAWord(Random r, Language[] lang = null, int approximete_length = -1)
            {
                if (lang == null)
                    lang = new Language[] { Language.en };
                string[] vowels = new string[] { };
                string[] consonants = new string[] { };
                if (approximete_length == -1)
                    approximete_length = r.Next(5, 10);
                string created = "";
                bool doublelettersallowed = true;
                if (lang.Length == 1)
                {
                    switch (lang[0])
                    {
                        case Language.en:
                            do
                                created += ensyllables[r.Next(0, ensyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.de:
                            do
                                created += desyllables[r.Next(0, desyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.mn:
                            do
                                created += mnsyllables[r.Next(0, mnsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.fr:
                            do
                                created += frsyllables[r.Next(0, frsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.nd:
                            do
                                created += ndsyllables[r.Next(0, ndsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.it:
                            do
                                created += itsyllables[r.Next(0, itsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.la:
                            do
                                created += lasyllables[r.Next(0, lasyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.es:
                            do
                                created += essyllables[r.Next(0, essyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.gr:
                            do
                                created += grsyllables[r.Next(0, grsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.zh:
                            do
                                created += zhsyllables[r.Next(0, zhsyllables.Length)];
                            while (created.Length < approximete_length);
                            doublelettersallowed = false;
                            break;
                        case Language.pl:
                            do
                                created += plsyllables[r.Next(0, plsyllables.Length)];
                            while (created.Length < approximete_length);
                            doublelettersallowed = false;
                            break;
                        case Language.sc:
                            do
                                created += scsyllables[r.Next(0, scsyllables.Length)];
                            while (created.Length < approximete_length);
                            break;
                        case Language.ru:
                            do
                                created += rusyllables[r.Next(0, rusyllables.Length)];
                            while (created.Length < approximete_length);
                            doublelettersallowed = false;
                            break;
                        case Language.nh:
                            if (r.Next(0, 4) == 0)
                                created += nhvowels[r.Next(0, nhvowels.Length)];
                            int c = 0;
                            do
                            {
                                created += nhsyllables[r.Next(0, nhsyllables.Length)];
                                if (c > 0 && created.Length + 1 < approximete_length && r.Next(0, 11) == 0)
                                    created += "'";
                                c++;
                            }
                            while (created.Length < approximete_length);
                            break;
                        case Language.jp:
                            vowels = jpvowels;
                            consonants = jpconsonants;
                            bool lastvowel = false;
                            do
                            {
                                if (!lastvowel && r.Next(0, 4) == 0)
                                {
                                    created += vowels[r.Next(0, vowels.Length)];
                                    lastvowel = true;
                                }
                                else
                                {
                                    created += consonants[r.Next(0, consonants.Length)];
                                    lastvowel = false;
                                }
                            }
                            while (created.Length < approximete_length);
                            break;
                    }
                }
                else
                {
                    do
                    {
                        Language picked = lang[r.Next(0, lang.Length)];
                        created += GenerateAWord(r, new Language[] { picked }, 0);
                    } while (created.Length < approximete_length);
                }

                if (doublelettersallowed)
                {
                    string necreated = "";
                    for (int a = 0; a < created.Length - 2; a++)
                    {
                        if (created[a] != created[a + 1] || created[a] != created[a + 2])
                        {
                            necreated += created[a].ToString();
                        }
                    }
                    created = necreated;
                }
                else
                {
                    string necreated = "";
                    for (int a = 0; a < created.Length - 1; a++)
                    {
                        if (created[a] != created[a + 1])
                        {
                            necreated += created[a].ToString();
                        }
                    }
                    created = necreated;
                }
                return created[0].ToString().ToUpper() + created.Substring(1, created.Length - 1).ToLower();
            }
        }

        static T RandomChoice<T>(T[] input, int[] chances, Random r)
        {
            if (input.Length == chances.Length)
            {
                if (input.Length > 0)
                {
                    int sumchances = 0;
                    int n = 0;
                    int[] trsh = new int[chances.Length];
                    int subch = 0;
                    foreach (int ch in chances)
                    {
                        if (ch >= 0)
                            subch = ch;
                        else
                            subch = 0;
                        sumchances += subch;
                        if (n == 0)
                            trsh[0] = subch;
                        else
                            trsh[n] = subch + trsh[n - 1];
                        n++;
                    }
                    int rand = r.Next(0, sumchances);
                    if (sumchances > 0)
                    {
                        for (int a = 0; a < n; a++)
                        {
                            if (rand < trsh[a] && chances[a] > 0)
                                return input[a];
                        }
                    }
                    return input[n - 1];
                }
                else
                    throw new Exception("RandomChoice: Arrays can't be empty!");
            }
            else
                throw new Exception("RandomChoice: Input array and Chances array have different ammount of elements!");
        }
    }


   
    class Region
    {
        public static int regionids = 0;
        public List<Province> provinces = new List<Province>();
        public int id = 0;
        public Region()
        {
            id = regionids;
            regionids++;
        }
    }

    class Province
    {
        public int id = 0;
        public Color terrain = Color.FromArgb(0, 0, 0, 0);
        public bool seatile = false;
        public bool borderingwater = false;
        public bool island = false;
        public bool hasriver = false;
        public Color climate = Color.FromArgb(0,0,0,0);
        public List<Point> points = new List<Point>();
        public Dictionary<Point, Color> resources = new Dictionary<Point, Color>();
        public List<Province> neighbours = new List<Province>();        
    }

    class Point
    {
        public int x = 0;
        public int y = 0;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Request
    {
        public int x = 0;
        public int y = 0;
        public int v = 0;
        public Request(int x, int y, int v)
        {
            this.x = x;
            this.y = y;
            this.v = v;
        }
    }
    class Cluster
    {
        public int x = 0;
        public int y = 0;
        public int sizex = 0;
        public int sizey = 0;
        public bool done = false;
        public Cluster(int x, int y, int sizex = 28, int sizey = 28)
        {
            this.x = x;
            this.y = y;
            this.sizex = sizex;
            this.sizey = sizey;
        }
    }


}
