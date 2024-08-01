// ============================================================
// Project Name   : AtCoderEnv
// File Name      : SkillCheck.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AtCoderEnv.Brother
{

public class MovingFloorMap
{
    private enum Direction
    {
        North,
        East,
        West,
        South
    }
    
    public int Height { get; init; }
    
    public int Width { get; init; }
    

    private readonly List<List<Direction>> m_MapData;

    private readonly List<List<bool>> m_IsPassedFloor;

    
    public MovingFloorMap(IReadOnlyList<string> input)
    {
        if (input.Count < 1)
        {
            throw new ArgumentException("Invalid length argument");
        }

        var line1 = input.First();
        var t = line1.Split(' ').Select(int.Parse).ToList();
        var h = t.First();
        var w = t.Last();

        Height = h;
        Width = w;

        m_MapData = new List<List<Direction>>();
        m_IsPassedFloor = new List<List<bool>>();

        if (input.Count < h + 1)
        {
            throw new ArgumentException("Invalid length argument");
        }
        
        for (var i = 0; i < h; i++)
        {
            var row_data = input[i + 1].Select(Char2Direction).ToList();
            m_MapData.Add(row_data);
            m_IsPassedFloor.Add(Enumerable.Range(0, Width).Select(_ => false).ToList());
        }
    }
    

    public int CountTracedFloorNum(Point start_position)
    {
        // 0スタートに変更
        var now_position = new Point(start_position.X - 1, start_position.Y - 1);
        var next_position = new Point(now_position.X, now_position.Y);
        
        var counter = 1;
        while (true)
        {
            cache_passed_floor(now_position);
            var floor_sign = get_floor_sign(now_position);
            subst_next_position(now_position, floor_sign, ref next_position);
            if (is_out_of_area(next_position))
            {
                break;
            }

            now_position = next_position;

            if (is_swing(now_position))
            {
                break;
            }
            counter++;
            if (counter > Height * Width)
            {
                throw new OverflowException("Traced floor number exceeds the amount of map floors. "
                                            + "Something went wrong.");
            }
        }

        return counter;
    }
    

    private static Direction Char2Direction(char c)
    {
        switch (c)
        {
        case 'N':
            return Direction.North;
        case 'E':
            return Direction.East;
        case 'W':
            return Direction.West;
        case 'S':
            return Direction.South;
        default:
            throw new ArgumentException("Not supported char was passed");
        }
    }


    private static void subst_next_position(Point now_position, Direction direction, ref Point next_position)
    {
        switch (direction)
        {
        case Direction.North:
            next_position.Y = now_position.Y - 1;
            next_position.X = now_position.X;
            break;
        case Direction.East:
            next_position.X = now_position.X + 1;
            next_position.Y = now_position.Y;
            break;
        case Direction.West:
            next_position.X = now_position.X - 1;
            next_position.Y = now_position.Y;
            break;
        case Direction.South:
            next_position.Y = now_position.Y + 1;
            next_position.X = now_position.X;
            break;
        }
    }


    private Direction get_floor_sign(Point point)
    {
        if (point.Y >= m_MapData.Count || point.X >= m_MapData[point.Y].Count)
        {
            throw new IndexOutOfRangeException("Argument locates out of the map.");
        }
        
        return m_MapData[point.Y][point.X];
    }


    private bool is_out_of_area(Point now_position)
    {
        if (now_position.X < 0 || now_position.Y < 0 || now_position.X >= Width || now_position.Y >= Height)
        {
            return true;
        }

        return false;
    }

    private bool is_swing(Point position)
    {
        if (position.Y >= m_MapData.Count || position.X >= m_MapData[position.Y].Count)
        {
            throw new IndexOutOfRangeException("Argument locates out of the map.");
        }
        
        return m_IsPassedFloor[position.Y][position.X];
    }


    private void cache_passed_floor(Point position)
    {
        if (position.Y >= m_MapData.Count || position.X >= m_MapData[position.Y].Count)
        {
            throw new IndexOutOfRangeException("Argument locates out of the map.");
        }
        
        m_IsPassedFloor[position.Y][position.X] = true;
    }
}

}