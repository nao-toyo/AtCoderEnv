// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A066.cs
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

public class A066
{
    public string Run(string n_str, IEnumerable<string> data)
    {
        int.TryParse(n_str, out var n);

        var d = data.Select(x => x.Split(' '))
                    .Select(x => new List<int> { int.Parse(x.First()), int.Parse(x.Last()) })
                    .ToList();
        
        var max_date = 100000;

        var renkin_days = new int[max_date + 1];

        foreach (var p in d)
        {
            var a = p.First();
            var b = p.Last();

            var start = a;
            while (true)
            {
                if (start <= 1)
                {
                    break;
                }
                if (renkin_days[start - 1] == 0)
                {
                    break;
                }
                start--;
            }

            var end = b;
            while (true)
            {
                if (end >= max_date)
                {
                    break;
                }
                if (renkin_days[end + 1] == 0)
                {
                    break;
                }
                end++;
            }

            for (var i = start; i <= end; i++)
            {
                renkin_days[i] = end - start + 1;
            }
        }

        return renkin_days.Max().ToString();
    }
}

}