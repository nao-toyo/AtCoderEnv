// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : B045Test.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using AtCoderEnv.Paiza;

namespace AtCoderEnvTest.Paiza
{

public class B045Test
{
    [Fact]
    public void BoundaryTest()
    {
        var head = "0 5050";

        var runner = new B045();
        var output = runner.Run(head);
        
        Console.WriteLine(output.First());
    }
}

}