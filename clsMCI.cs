using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XXuanSCADA
{
    // Token: 0x02000002 RID: 2
    public class clsMCI
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
        // (set) Token: 0x06000003 RID: 3 RVA: 0x000020A8 File Offset: 0x000002A8
        public string FileName
        {
            get
            {
                return this.mc.iName;
            }
            set
            {
                try
                {
                    this.TemStr = "";
                    this.TemStr = this.TemStr.PadLeft(127, Convert.ToChar(" "));
                    this.Name = this.Name.PadLeft(260, Convert.ToChar(" "));
                    this.mc.iName = value;
                    this.ilong = APIClass.GetShortPathName(this.mc.iName, this.Name, this.Name.Length);
                    this.Name = this.GetCurrPath(this.Name);
                    this.Name = string.Concat(new object[]
                    {
                        "open ",
                        Convert.ToChar(34),
                        this.Name,
                        Convert.ToChar(34),
                        " alias media"
                    });
                    this.ilong = APIClass.mciSendString("close all", this.TemStr, this.TemStr.Length, 0);
                    this.ilong = APIClass.mciSendString(this.Name, this.TemStr, this.TemStr.Length, 0);
                    this.ilong = APIClass.mciSendString("set media time format milliseconds", this.TemStr, this.TemStr.Length, 0);
                    this.mc.state = clsMCI.State.mStop;
                }
                catch
                {
                }
            }
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002228 File Offset: 0x00000428
        public void play()
        {
            this.TemStr = "";
            this.TemStr = this.TemStr.PadLeft(127, Convert.ToChar(" "));
            APIClass.mciSendString("play media", this.TemStr, this.TemStr.Length, 0);
            this.mc.state = clsMCI.State.mPlaying;
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002288 File Offset: 0x00000488
        public void StopT()
        {
            this.TemStr = "";
            this.TemStr = this.TemStr.PadLeft(128, Convert.ToChar(" "));
            this.ilong = APIClass.mciSendString("close media", this.TemStr, 128, 0);
            this.ilong = APIClass.mciSendString("close all", this.TemStr, 128, 0);
            this.mc.state = clsMCI.State.mStop;
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002308 File Offset: 0x00000508
        public void Puase()
        {
            this.TemStr = "";
            this.TemStr = this.TemStr.PadLeft(128, Convert.ToChar(" "));
            this.ilong = APIClass.mciSendString("pause media", this.TemStr, this.TemStr.Length, 0);
            this.mc.state = clsMCI.State.mPuase;
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002370 File Offset: 0x00000570
        private string GetCurrPath(string name)
        {
            string result;
            if (name.Length < 1)
            {
                result = "";
            }
            else
            {
                name = name.Trim();
                name = name.Substring(0, name.Length - 1);
                result = name;
            }
            return result;
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000008 RID: 8 RVA: 0x000023B4 File Offset: 0x000005B4
        public int Duration
        {
            get
            {
                this.durLength = "";
                this.durLength = this.durLength.PadLeft(128, Convert.ToChar(" "));
                APIClass.mciSendString("status media length", this.durLength, this.durLength.Length, 0);
                this.durLength = this.durLength.Trim();
                int result;
                if (this.durLength == "")
                {
                    result = 0;
                }
                else
                {
                    result = (int)(Convert.ToDouble(this.durLength) / 1000.0);
                }
                return result;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000009 RID: 9 RVA: 0x00002450 File Offset: 0x00000650
        public int CurrentPosition
        {
            get
            {
                this.durLength = "";
                this.durLength = this.durLength.PadLeft(128, Convert.ToChar(" "));
                APIClass.mciSendString("status media position", this.durLength, this.durLength.Length, 0);
                this.mc.iPos = (int)(Convert.ToDouble(this.durLength) / 1000.0);
                return this.mc.iPos;
            }
        }

        // Token: 0x04000001 RID: 1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        private string Name = "";

        // Token: 0x04000002 RID: 2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        private string durLength = "";

        // Token: 0x04000003 RID: 3
        [MarshalAs(UnmanagedType.LPTStr)]
        private string TemStr = "";

        // Token: 0x04000004 RID: 4
        private int ilong;

        // Token: 0x04000005 RID: 5
        public clsMCI.structMCI mc = default(clsMCI.structMCI);

        // Token: 0x02000003 RID: 3
        public enum State
        {
            // Token: 0x04000007 RID: 7
            mPlaying = 1,
            // Token: 0x04000008 RID: 8
            mPuase,
            // Token: 0x04000009 RID: 9
            mStop
        }

        // Token: 0x02000004 RID: 4
        public struct structMCI
        {
            // Token: 0x0400000A RID: 10
            public bool bMut;

            // Token: 0x0400000B RID: 11
            public int iDur;

            // Token: 0x0400000C RID: 12
            public int iPos;

            // Token: 0x0400000D RID: 13
            public int iVol;

            // Token: 0x0400000E RID: 14
            public int iBal;

            // Token: 0x0400000F RID: 15
            public string iName;

            // Token: 0x04000010 RID: 16
            public clsMCI.State state;
        }
    }
}
