using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
  public class Queen
  {
    public Queen(int xPosition, int yPosition)
    {
      PositionX = xPosition;
      PositionY = yPosition;
    }
    public int PositionX {get; set;}
    public int PositionY {get; set;}
    
    public bool CanQueenMove(int OX, int OY)
		{
			if (PositionX == OX || PositionY == OY || (Math.Abs(PositionX - OX)) == (Math.Abs(PositionY - OY)))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
  }
}
