// ============================================================
// Project Name   : AtCoderEnv
// File Name      : A059.cs
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

public class A059
{
    public string Run(string line1, string[] lines)
    {
        var t = line1.Split(' ').Select(int.Parse).ToList();
        var w_limit = t.Last();

        var targets = lines.Select(x => x.Split(' ')).ToList();

        var cost_performances = targets.Select(x => double.Parse(x[1]) / double.Parse(x[0]))
                                       .Select((x, idx) => (idx, x));

        var sorted = cost_performances.OrderByDescending(x => x.x).ToList();

        var amount_w = 0;
        var amount_b = 0;
        
        // コスパ順に並べる
        // 先頭から採用する
        // 同時に、それを採用することで弾かれるリストを抽出
        // そのリストからのみ抽出した
        
        foreach (var cp in sorted)
        {
            var w = int.Parse(targets[cp.idx][0]);
            if (amount_w + w >= w_limit)
            {
                continue;
            }
            
            amount_w += w;
            var b = int.Parse(targets[cp.idx][1]);
            amount_b += b;
        }

        return amount_b.ToString();
    }
}

}