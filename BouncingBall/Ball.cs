﻿namespace BouncingBall
{
    internal class Ball
    {
        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;
        private int _color;

        public Ball(int col, int row, int speedCol, int speedRow, int color)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
            _color = color;
        }

        public void Show()
        {
            Console.ForegroundColor = (ConsoleColor)_color;
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            Console.Write("O");
        }

        public void Move()
        {
            _col += _speedCol;
            _row += _speedRow;
            if (_col <= 0 || _col >= Console.WindowWidth-1) _speedCol = -_speedCol;
            if (_row <= 0 || _row >= Console.WindowHeight-1) _speedRow = -_speedRow;
        }
        public void CheckForCollisionAndAdjust(Ball ball2)
        {
            if (_col != ball2._col || _row != ball2._row) return;
            var temp1 = _speedCol;
            var temp2 = _speedRow;
            if (_speedCol == ball2._speedCol)
            {
                _speedCol = -_speedCol;
            }
            else
            {
                _speedCol = ball2._speedCol;
                ball2._speedCol = temp1;
            }
            if (_speedRow == ball2._speedRow)
            {
                _speedRow = -_speedRow;
            }
            else
            {
                _speedRow = ball2._speedRow;
                ball2._speedRow = temp2;
            }
        }
        
    }
}