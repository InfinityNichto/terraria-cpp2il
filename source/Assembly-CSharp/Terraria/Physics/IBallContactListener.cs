using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x020003A4 RID: 932
	[global::Cpp2ILInjected.Token(Token = "0x2000543")]
	public interface IBallContactListener
	{
		// Token: 0x06002E0A RID: 11786
		[global::Cpp2ILInjected.Token(Token = "0x6003269")]
		void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision);

		// Token: 0x06002E0B RID: 11787
		[global::Cpp2ILInjected.Token(Token = "0x600326A")]
		void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent passThrough);
	}
}
