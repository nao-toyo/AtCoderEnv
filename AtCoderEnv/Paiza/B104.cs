// ============================================================
// Project Name   : AtCoderEnv
// File Name      : B104.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System.Collections.Generic;
using System.Linq;

namespace AtCoderEnv.Paiza
{

public class B104
{
    public IEnumerable<int> Run(string head, string[] lines)
    {
        var t = head.Split(' ').Select(int.Parse).ToList();
        var m = t.Last();

        var t2 = lines.Select(x => x.Split(' ')).ToList();

        var ret = new List<int>();
        
        foreach (var i in Enumerable.Range(0, m))
        {
            var cleansed_mi = t2.Select(x => x[i])
                                .Where(x => int.TryParse(x, out _))
                                .Select(int.Parse)
                                .Where(x => (x >= 0 && x <= 100))
                                .ToList();

            if (cleansed_mi.Count < 1)
            {
                ret.Add(0);
            }
            else
            {
                var mean = (double)cleansed_mi.Sum() / cleansed_mi.Count;
                ret.Add((int)mean);
            }
        }

        return ret;
    }
}

}