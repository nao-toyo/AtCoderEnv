// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A023.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System.Linq;

namespace AtCoderEnv.Paiza
{

public class A023
{
    public string Run(string n_str, string d)
    {
        var n = int.Parse(n_str);
        var data = d.Split(' ').Select(int.Parse).ToList();

        var scan_num = n - 7;

        var max_s = -1;
        var s = 0;
        var first = data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[6];
        if (first <= 5)
        {
            s = 7;
        }
        
        for (var i = 0; i < scan_num; i++)
        {
            var t = data[i + 1] + data[i + 2] + data[i + 3] + data[i + 4] + data[i + 5] + data[i + 6] + data[i + 7];
            if (t <= 5)
            {
                if (s == 0)
                {
                    s = 7;
                }
                else
                {
                    s++;
                }
            }
            else
            {
                if (s > max_s)
                {
                    max_s = s;
                }
                s = 0;
            }

        }

        return max_s.ToString();
    }
}

}