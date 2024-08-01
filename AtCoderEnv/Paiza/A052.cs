// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A052.cs
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

public class A052
{
    public string Run(string line1, string line2)
    {
        var n = int.Parse(line1);
        var t = line2.Split(' ').Select(int.Parse).ToList();
        var a = t.First();
        var b = t.Last();

        var unreachable_x = new List<int>();
        foreach (var x in Enumerable.Range(1, n - 1))
        {
            if (x % a == 0 || x % b == 0)
            {
                continue;
            }
            
            var allowable_max_nb = x / b + 1;

            var reachable = false;
            foreach (var nb in Enumerable.Range(0, allowable_max_nb))
            {
                var last_x = x - nb * b;
                if (last_x % a == 0)
                {
                    reachable = true;
                    break;
                }
            }
            
            if (reachable == false)
            {
                unreachable_x.Add(x);
            }
        }

        return unreachable_x.Count().ToString();
    }
}

}