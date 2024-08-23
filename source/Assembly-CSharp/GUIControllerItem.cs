using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000066 RID: 102
[global::Cpp2ILInjected.Token(Token = "0x2000093")]
public interface GUIControllerItem
{
	// Token: 0x060002F1 RID: 753
	[global::Cpp2ILInjected.Token(Token = "0x600038B")]
	void Activate();

	// Token: 0x060002F2 RID: 754
	[global::Cpp2ILInjected.Token(Token = "0x600038C")]
	GUIControllerItem Navigate(Vector2 navigationVector);

	// Token: 0x060002F3 RID: 755
	[global::Cpp2ILInjected.Token(Token = "0x600038D")]
	Rectangle GetSelectedItemRegion();

	// Token: 0x060002F4 RID: 756
	[global::Cpp2ILInjected.Token(Token = "0x600038E")]
	int GetNavigationOutDirs();
}
