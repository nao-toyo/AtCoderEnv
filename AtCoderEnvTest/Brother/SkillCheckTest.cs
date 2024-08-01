// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : SkillCheckTest.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System.Drawing;
using AtCoderEnv.Brother;

namespace AtCoderEnvTest.Brother
{

public class SkillCheckTest
{
    [Fact]
    public void Test()
    {
        var input = new List<string>()
                    {
                        "2 3",
                        "SNS",
                        "EEN"
                    };
        
        var runner = new MovingFloorMap(input);
        
        var output = runner.CountTracedFloorNum(new Point(1, 1)).ToString();
        
        Assert.Equal("5", output);
    }
    
    [Fact]
    public void Test2()
    {
        var input = new List<string>()
                    {
                        "3 3",
                        "NSS",
                        "SSS",
                        "SSS"
                    };
        
        var runner = new MovingFloorMap(input);
        
        var output = runner.CountTracedFloorNum(new Point(1, 1)).ToString();
        
        Assert.Equal("1", output);
    }
    
    
    [Fact]
    public void Test3()
    {
        var input = new List<string>()
                    {
                        "5 5",
                        "SWWWW",
                        "SSSSN",
                        "SSSSN",
                        "SSSSN",
                        "EEEEN",
                    };
        
        var runner = new MovingFloorMap(input);
        
        var output = runner.CountTracedFloorNum(new Point(1, 1)).ToString();

        Assert.Equal("16", output);
    }


}

}