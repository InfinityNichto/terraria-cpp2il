using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000289 RID: 649
	[global::Cpp2ILInjected.Token(Token = "0x2000380")]
	public interface ICustomTypeDescriptor
	{
		// Token: 0x0600153E RID: 5438
		[global::Cpp2ILInjected.Token(Token = "0x6001789")]
		AttributeCollection GetAttributes();

		// Token: 0x0600153F RID: 5439
		[global::Cpp2ILInjected.Token(Token = "0x600178A")]
		string GetClassName();

		// Token: 0x06001540 RID: 5440
		[global::Cpp2ILInjected.Token(Token = "0x600178B")]
		string GetComponentName();

		// Token: 0x06001541 RID: 5441
		[global::Cpp2ILInjected.Token(Token = "0x600178C")]
		TypeConverter GetConverter();

		// Token: 0x06001542 RID: 5442
		[global::Cpp2ILInjected.Token(Token = "0x600178D")]
		EventDescriptor GetDefaultEvent();

		// Token: 0x06001543 RID: 5443
		[global::Cpp2ILInjected.Token(Token = "0x600178E")]
		PropertyDescriptor GetDefaultProperty();

		// Token: 0x06001544 RID: 5444
		[global::Cpp2ILInjected.Token(Token = "0x600178F")]
		object GetEditor(Type editorBaseType);

		// Token: 0x06001545 RID: 5445
		[global::Cpp2ILInjected.Token(Token = "0x6001790")]
		EventDescriptorCollection GetEvents();

		// Token: 0x06001546 RID: 5446
		[global::Cpp2ILInjected.Token(Token = "0x6001791")]
		EventDescriptorCollection GetEvents(Attribute[] attributes);

		// Token: 0x06001547 RID: 5447
		[global::Cpp2ILInjected.Token(Token = "0x6001792")]
		PropertyDescriptorCollection GetProperties();

		// Token: 0x06001548 RID: 5448
		[global::Cpp2ILInjected.Token(Token = "0x6001793")]
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);

		// Token: 0x06001549 RID: 5449
		[global::Cpp2ILInjected.Token(Token = "0x6001794")]
		object GetPropertyOwner(PropertyDescriptor pd);
	}
}
