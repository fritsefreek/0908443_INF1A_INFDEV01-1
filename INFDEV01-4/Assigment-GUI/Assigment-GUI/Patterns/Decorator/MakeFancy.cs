using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public abstract class MakeFancyDecorator : IControl
	{
		IControl m_BaseComponent;

		protected MakeFancyDecorator(IControl baseComponent)
		{
			m_BaseComponent = baseComponent;
		}

		#region IControl implementation

		public void Update ()
		{
			throw new NotImplementedException ();
		}

		public void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch spritebatch, Microsoft.Xna.Framework.Graphics.SpriteFont font, System.Collections.Generic.Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> buttonStates)
		{
			spritebatch.Draw (buttonStates[m_BaseComponent.Texture], m_BaseComponent.Position, null, Color.White, 0f, Vector2.Zero, m_BaseComponent.Size, SpriteEffects.None, 0f);
		}

		public void Visit (IControlVisitor IControlVisitor)
		{
			throw new NotImplementedException ();
		}

		public Vector2 Position {
			get {
				return m_BaseComponent.Position;
			}
			set {
				m_BaseComponent.Position = value;
			}
		}

		public Vector2 Size {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public string Texture
		{
			get
			{
				return m_BaseComponent.Texture;
			}
			set
			{
				m_BaseComponent.Texture = value;
			}
		}
		#endregion
		
	}
}