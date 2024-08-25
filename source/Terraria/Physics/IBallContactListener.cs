using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000543")]
	public interface IBallContactListener
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003269")]
		void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision);

		[global::Cpp2ILInjected.Token(Token = "0x600326A")]
		void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent passThrough);
	}
}
