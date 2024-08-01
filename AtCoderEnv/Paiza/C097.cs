// ============================================================
// Project Name   : AtCoderEnv
// File Name      : C097.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System;
using System.Linq;
using System.Text;

namespace AtCoderEnv.Paiza
{

public class C097
{
    public string Run(string input_line)
    {
        var data = input_line.Split(' ').Select(int.Parse).ToList();
        var n = data[0];
        var x = data[1];
        var y = data[2];

        var present_a = "A";
        var present_b = "B";
        var present_nothing = "N";

        var sb = new StringBuilder((int)(3.5 * n));

        foreach (var i in Enumerable.Range(1, n))
        {
            if (i % x == 0)
            {
                sb.Append(present_a);
            }
            if (i % y == 0)
            {
                sb.Append(present_b);
            }

            if (i % x != 0 && i % y != 0)
            {
                sb.Append(present_nothing);
            }
            
            sb.Append(Environment.NewLine);
        }

        return sb.ToString();
    }
}

}