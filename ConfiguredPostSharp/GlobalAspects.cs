﻿using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;
// This file contains registration of aspects that are applied to several classes of this project.
[assembly: Log(AttributeTargetTypeAttributes = MulticastAttributes.Private | MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public, AttributeTargetMemberAttributes = MulticastAttributes.Private | MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public)]
[assembly: LogException(AttributeTargetTypeAttributes = MulticastAttributes.Private | MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public, AttributeTargetMemberAttributes = MulticastAttributes.Private | MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public)]
