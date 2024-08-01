// ============================================================
// Project Name   : AtCoderEnv
// File Name      : B045.cs
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

public class B045
{
    public IEnumerable<string> Run(string head)
    {
        var t = head.Split(' ').Select(int.Parse).ToList();
        var sum_problem_num = t.First();
        var sbst_problem_num = t.Last();

        var ret = new List<string>();
        
        // 足し算
        var counter = 0;
        for (var a = 0; a < 100; a++)
        {
            if (counter >= sum_problem_num)
            {
                break;
            }
            
            var max_b = 99 - a;
            foreach (var b in Enumerable.Range(0, max_b + 1))
            {
                ret.Add($"{a} + {b} =");
                counter++;
                if (counter >= sum_problem_num)
                {
                    break;
                }
            }
            
            if (counter >= sum_problem_num)
            {
                break;
            }
        }
        
        // 引き算
        counter = 0;
        for (var a = 99; a >= 0; a--)
        {
            if (counter >= sbst_problem_num)
            {
                break;
            }
            
            var max_b_cnt = a + 1;
            var b_start = max_b_cnt - 1;
            foreach (var b in Enumerable.Range(0, max_b_cnt))
            {
                ret.Add($"{a} - {b_start} =");
                b_start--;
                counter++;
                if (counter >= sbst_problem_num)
                {
                    break;
                }
            }
            
            if (counter >= sbst_problem_num)
            {
                break;
            }
        }

        return ret;
    }
}

}