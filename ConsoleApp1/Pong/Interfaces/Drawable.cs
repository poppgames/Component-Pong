﻿namespace ComponentConsolePong
{
	/// <summary>
	///  Allows a <see cref="GameObject"/> or <see cref="Component"/> to render a character on the board each frame. Called after Update
	/// </summary>
	public interface Drawable
	{
		void Draw(Board board);
		char GetChar();
	}

	/// <summary>
	/// Allows <see cref="Component"/>s on a <see cref="GameObject"/> to be drawn
	/// </summary>
	public interface CoponentDrawable
	{
	}
}
