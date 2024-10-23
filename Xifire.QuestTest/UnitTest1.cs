using Xifire.QuestManagement;

namespace Xifire.QuestTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var saveData = MasterData.Master;
        saveData.Quests["1"].Status = QuestStatus.Available;

        var condition = ConditionFactory.New(ConditionType.HasItem, "アイテム1", 2);
        if (!condition.IsValid(saveData))
            throw new Exception();
    }
}
