using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
  public interface IFactory : IComponent
  {
    Vector2 Position { get; }
	List<IContainer> ProductsToShip { get; set;}
    ITruck GetReadyTruck();
	Texture2D TruckTexture { get; }
	Texture2D ContainerTexture { get; }
  }
}
