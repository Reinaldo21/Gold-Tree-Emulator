using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.Messages;
namespace GoldTree.Communication.Messages.Navigator
{
	internal sealed class RoomsWhereMyFriendsAreSearchMessageEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
			Session.SendMessage(GoldTree.GetGame().GetNavigator().method_12(Session, -5));
		}
	}
}
