﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 酷狗音乐UWP.Class
{
    public class MediaControl
    {
        
        public static Windows.Media.Playback.MediaPlayer GetCurrent()
        {
            return Windows.Media.Playback.BackgroundMediaPlayer.Current;
        }
    }
}