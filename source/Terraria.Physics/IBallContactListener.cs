using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A7")]
public interface IBallContactListener
{
	[Cpp2IlInjected.Token(Token = "0x6002E42")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision);

	[Cpp2IlInjected.Token(Token = "0x6002E43")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent passThrough);
}
