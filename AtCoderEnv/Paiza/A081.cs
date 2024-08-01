// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A081.cs
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

namespace AtCoderEnv.Paiza
{

public class A081
{
    public string Run(string n_str, IEnumerable<string> data)
    {
        var n = int.Parse(n_str);
        var d = data.Select(x => int.Parse(x)).ToList();

        var d2 = new List<Tuple<int, int>>(2 * n);
        for (var i = 0; i < 2 * n; i++)
        {
            d2.Add(new Tuple<int, int>(i, d[i]));
        }
        
        // var d2 = d.Select((x, idx) => (idx, x)).ToList();

        d2.Sort((a, b) => a.Item2.CompareTo(b.Item2));

        long s = 0;
        for (var i = 0; i < n; i++)
        {
            var t1 = d2[i * 2];
            var t2 = d2[i * 2 + 1];

            s += Math.Abs(t2.Item1 - t1.Item1) - 1;
        }

        return s.ToString();
    }
}

}