﻿using System;
using System.Collections.Generic;
using Vixen.Sys;

namespace Vixen.Execution {
	//T = type of state being added to a channel
	//U = type of the state retrieved for a channel
	//Could be a multiple command (T) instances going in and a single command (U) coming out
	//Could be multiple intent (T) instances going in and multiple intents (U) coming out
	class IntentStateBuilder : IChannelStateBuilder<IIntentState, IIntentStateList> {
		private Dictionary<Guid, IIntentStateList> _channelStates;

		public IntentStateBuilder() {
			_channelStates = new Dictionary<Guid, IIntentStateList>();
		}

		public void Clear() {
			_channelStates.Clear();
		}

		public void AddChannelState(Guid channelId, IIntentState state) {
			IIntentStateList channelIntentList = _GetChannelIntentList(channelId);
			channelIntentList.AddIntentState(state);
		}

		public IIntentStateList GetChannelState(Guid channelId) {
			return _GetChannelIntentList(channelId);
		}

		private IIntentStateList _GetChannelIntentList(Guid channelId) {
			IIntentStateList channelIntentList;
			if(!_channelStates.TryGetValue(channelId, out channelIntentList)) {
				channelIntentList = new IntentStateList();
				_channelStates[channelId] = channelIntentList;
			}
			return channelIntentList;
		}
	}
}
