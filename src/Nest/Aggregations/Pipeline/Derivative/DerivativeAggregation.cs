﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IDerivativeAggregation : IPipelineAggregation { }

	public class DerivativeAggregation : PipelineAggregationBase, IDerivativeAggregation
	{
		public DerivativeAggregation(string name, string bucketsPath)
			: base(name, bucketsPath) { }

		internal override void WrapInContainer(AggregationContainer c) => c.Derivative = this;
	}

	public class DerivativeAggregationDescriptor
		: PipelineAggregationDescriptorBase<DerivativeAggregationDescriptor, IDerivativeAggregation>, IDerivativeAggregation { }
}
