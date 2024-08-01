// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : C097Test.cs
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

public class C097Test
{
    [Fact]
    public void NormalTest()
    {
        var input = "5 2 4";

        var runner = new C097();

        var output = runner.Run(input);
        
        Console.WriteLine(output);
    }
}

}