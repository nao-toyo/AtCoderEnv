// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A051.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.SafeHandles;

namespace AtCoderEnv.Paiza
{

public class A051
{
    public string Run(string n, IEnumerable<string> data)
    {
        var t = n.Split(' ').Select(int.Parse).ToList();
        var h = t.First();
        var w = t.Last();

        var points = new int[h, w];

        var ii = 0;
        foreach (var d in data)
        {
            var t2 = d.Split(' ').Select(int.Parse);
            var jj = 0;
            foreach (var rowdata in t2)
            {
                points[ii, jj++] = rowdata;
            }
            ii++;
        }

        var max_points = new int[w];

        for (var i = 0; i < w; i++)
        {
            max_points[i] = points[0, i];
        }

        var cache = new int[w];

        for (var i = 1; i < h; i++)
        {
            for (var j = 0; j < w; j++)
            {
                var now_point = points[i, j];
                var m = get_max_point(now_point, j, max_points);
                cache[j] = m;
            }
            
            for (var j = 0; j < w; j++)
            {
                max_points[j] = cache[j];
                cache[j] = 0;
            }
        }

        return max_points.Max().ToString();
    }


    public int get_max_point(int now_position_point, int col_num, int[] max_points)
    {
        var t1 = max_points[col_num];
        var t2 = t1;
        if (col_num > 0)
        {
            t2 = max_points[col_num - 1];
        }
        var t3 = t1;
        if (col_num < max_points.Length - 1)
        {
            t3 = max_points[col_num + 1];
        }

        if (t1 >= t2 && t1 >= t3)
        {
            return t1 + now_position_point;
        }
        if (t2 >= t1 && t2 >= t3)
        {
            return t2 + now_position_point;
        }

        return t3 + now_position_point;
    }
}

}