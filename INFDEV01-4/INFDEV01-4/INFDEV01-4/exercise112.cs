using System;
using System.Collections.Generic;

namespace INFDEV014
{
	public class exercise112
	{
		interface ISong
		{
			 void visit(IMusicLibraryVisitor vistor);
		}

		class Jazz : ISong
		{
			#region ISong implementation

			public void visit (IMusicLibraryVisitor vistor)
			{
				vistor.onJazz (this);
			}

			#endregion
		}

		class HeavyMetal : ISong
		{
			#region ISong implementation

			public void visit (IMusicLibraryVisitor vistor)
			{
				vistor.onHeavyMetal (this);
			}

			#endregion
		}

		interface IMusicLibraryVisitor
		{
			void onHeavyMetal(HeavyMetal song);
			void onJazz(Jazz song);
		}

		class MusicLibraryVisitor : IMusicLibraryVisitor
		{
			public List<Jazz> jazzSongs = new List<Jazz>();
			List<HeavyMetal> heavyMetalSongs = new List<HeavyMetal>();

			#region IMusicLibraryVisitor implementation

			public void onHeavyMetal (HeavyMetal song)
			{
				this.heavyMetalSongs.Add(song);
			}

			public void onJazz (Jazz song)
			{
				this.jazzSongs.Add(song);
			}

			#endregion
		}

		public exercise112 ()
		{
			MusicLibraryVisitor musicLibraryVisitor = new MusicLibraryVisitor();
			musicLibraryVisitor.onJazz(new Jazz());
			musicLibraryVisitor.onHeavyMetal(new HeavyMetal());
			Console.Read();
		}
	}
}

