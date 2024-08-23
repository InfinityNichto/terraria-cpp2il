using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000288 RID: 648
	[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
	[global::Cpp2ILInjected.Token(Token = "0x200037F")]
	public interface IComNativeDescriptorHandler
	{
		// Token: 0x06001532 RID: 5426
		[global::Cpp2ILInjected.Token(Token = "0x600177D")]
		AttributeCollection GetAttributes(object component);

		// Token: 0x06001533 RID: 5427
		[global::Cpp2ILInjected.Token(Token = "0x600177E")]
		string GetClassName(object component);

		// Token: 0x06001534 RID: 5428
		[global::Cpp2ILInjected.Token(Token = "0x600177F")]
		TypeConverter GetConverter(object component);

		// Token: 0x06001535 RID: 5429
		[global::Cpp2ILInjected.Token(Token = "0x6001780")]
		EventDescriptor GetDefaultEvent(object component);

		// Token: 0x06001536 RID: 5430
		[global::Cpp2ILInjected.Token(Token = "0x6001781")]
		PropertyDescriptor GetDefaultProperty(object component);

		// Token: 0x06001537 RID: 5431
		[global::Cpp2ILInjected.Token(Token = "0x6001782")]
		object GetEditor(object component, Type baseEditorType);

		// Token: 0x06001538 RID: 5432
		[global::Cpp2ILInjected.Token(Token = "0x6001783")]
		string GetName(object component);

		// Token: 0x06001539 RID: 5433
		[global::Cpp2ILInjected.Token(Token = "0x6001784")]
		EventDescriptorCollection GetEvents(object component);

		// Token: 0x0600153A RID: 5434
		[global::Cpp2ILInjected.Token(Token = "0x6001785")]
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		// Token: 0x0600153B RID: 5435
		[global::Cpp2ILInjected.Token(Token = "0x6001786")]
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		// Token: 0x0600153C RID: 5436
		[global::Cpp2ILInjected.Token(Token = "0x6001787")]
		object GetPropertyValue(object component, string propertyName, ref bool success);

		// Token: 0x0600153D RID: 5437
		[global::Cpp2ILInjected.Token(Token = "0x6001788")]
		object GetPropertyValue(object component, int dispid, ref bool success);
	}
}
