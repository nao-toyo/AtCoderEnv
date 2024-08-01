// // ============================================================
// // Project Name   : AtCoderEnv
// // File Name      : A060.cs
// // Encoding       : utf-8
// // Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// // 
// // Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// // This source code or any portion thereof must not be
// // reproduced or used in any manner whatsoever
// // ============================================================
//
// using System.Drawing;
// using System.Text;
//
// namespace AtCoderEnv.Paiza
// {
//
// public class A060
// {
//     public string Run(string line1, string[] lines)
//     {
//         var t = line1.Split(' ').Select(int.Parse).ToList();
//         var h = t.First();
//         var w = t.Last();
//
//         var start_y = lines.Select((x, idx) => (idx, x)).Where(x => x.x.Contains('S')).Select(x => x.idx).First();
//         var goal_y = lines.Select((x, idx) => (idx, x)).Where(x => x.x.Contains('G')).Select(x => x.idx).First();
//
//         var start_x = lines[start_y].IndexOf('S');
//         var goal_x = lines[goal_y].IndexOf('G');
//
//         var now_x = start_x;
//         var now_y = start_y;
//
//         var div_x = goal_x - now_x;
//         var div_y = goal_y - now_y;
//
//         var ii = new MoveIntelligence(h, w, lines);
//         /*
//          * Gから壁にぶつかるまで移動(地点a)
//          * Sから壁にぶつかるまで移動(地点b)
//          * 地点aから地点bまで壁伝いに移動
//          */
//         
//         throw new NotImplementedException();
//     }
//
//
//     public class MoveIntelligence
//     {
//         private readonly IReadOnlyList<string> m_MapData;
//
//         private readonly Point m_StartPoint;
//         private readonly Point m_GoalPoint;
//
//         private Point m_NowPoint;
//
//         private Point m_LockedOnWallPoint = new Point(-1, -1);
//
//         private readonly int m_Height;
//         private readonly int m_Widh;
//
//         private StringBuilder m_History = new StringBuilder();
//
//         public MoveIntelligence(int h, int w, IReadOnlyList<string> mapdata)
//         {
//             m_Height = h;
//             m_Widh = w;
//             m_MapData = mapdata.Reverse().ToList();
//             
//             var lines = m_MapData;
//             var start_y = lines.Select((x, idx) => (idx, x)).Where(x => x.x.Contains('S')).Select(x => x.idx).First();
//             var goal_y = lines.Select((x, idx) => (idx, x)).Where(x => x.x.Contains('G')).Select(x => x.idx).First();
//
//             var start_x = lines[start_y].IndexOf('S');
//             var goal_x = lines[goal_y].IndexOf('G');
//
//             m_StartPoint = new Point(start_x, start_y);
//             m_GoalPoint = new Point(goal_x, goal_y);
//             
//             m_NowPoint = m_StartPoint;
//         }
//
//
//         public void Step(char direction)
//         {
//             
//         }
//
//         private char get_area_code(int x, int y)
//         {
//             return m_MapData[y][x];
//         }
//
//         private bool is_exist_in_area(int x, int y)
//         {
//             return x < m_Widh && y < m_Height;
//         }
//
//         private int calculate_step_to_wall(char direction)
//         {
//             var now_x = m_NowPoint.X;
//             var now_y = m_NowPoint.Y;
//
//             var step_counter = 0;
//
//             bool is_wall_point(int x, int y) => get_area_code(x, y) == '#';
//             
//             while (true)
//             {
//                 switch (direction)
//                 {
//                 case 'U':
//                     now_y += 1;
//                     break;
//                 case 'D':
//                     now_y -= 1;
//                     break;
//                 case 'L':
//                     now_x -= 1;
//                     break;
//                 case 'R':
//                     now_x += 1;
//                     break;
//                 }
//                 step_counter++;
//                 if (is_exist_in_area(now_x, now_y) == false)
//                 {
//                     return -1;
//                 }
//                 if (is_wall_point(now_x, now_y))
//                 {
//                     return step_counter;
//                 }
//             }
//         }
//
//
//         private void add_history(char direction, int step)
//         {
//             m_History.Append(new string(direction, step));
//         }
//         
//         
//         private void lock_on_wall()
//         {
//             // 上下左右の順で壁を探索
//
//             var div_x = m_GoalPoint.X - m_NowPoint.X;
//             var div_y = m_GoalPoint.Y - m_NowPoint.Y;
//
//             var direction_prior = new StringBuilder();
//
//             if (Math.Abs(div_x) > Math.Abs(div_y))
//             {
//                 if (div_x > 0)
//                 {
//                     direction_prior.Append('R');
//                 }
//                 else
//                 {
//                     direction_prior.Append('L');
//                 }
//                 if (div_y > 0)
//                 {
//                     direction_prior.Append('D');
//
//                 }
//             }
//             if (Math.Abs(div_x) > Math.Abs(div_y))
//             {
//                 if (div_x > 0)
//                 {
//                     direction_prior.Add('R');
//                 }
//                 else
//                 {
//                     direction_prior.Add('L');
//                 }
//             }
//
//             if (m_NowPoint.Y > m_GoalPoint.Y)
//             {
//                 var step = calculate_step_to_wall('D');
//                 if (step > 0)
//                 {
//                     add_history('D');
//                     return;
//                 }
//             }
//             else
//             {
//                 var step = calculate_step_to_wall('U');
//                 if (step > 0)
//                 {
//                     return;
//                 }
//             }
//
//             if (m_NowPoint.X > m_GoalPoint.X)
//             {
//                 var step = calculate_step_to_wall('R');
//                 if (step > 0)
//                 {
//                     return;
//                 }
//             }
//             else
//             {
//                 var step = calculate_step_to_wall('L');
//                 if (step > 0)
//                 {
//                     return;
//                 }
//             }
//
//         }
//     }
// }
//
// }