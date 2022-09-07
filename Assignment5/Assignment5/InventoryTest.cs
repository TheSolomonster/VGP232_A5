using NUnit.Framework;


namespace Assignment5
{
    class InventoryTest
    {
        private Inventory inventory;
        private Item i1;
        private Item i2;
        private Item i3;

        [SetUp]
        public void Setup()
        {
            inventory = new Inventory(3);
            i2 = new Item("nice smelling key", 4, ItemGroup.Key);
            i1 = new Item("bread", 5, ItemGroup.Consumable);
            i3 = new Item("chef hat", 3, ItemGroup.Equipment);
        }

        [Test]
        public void AddAndRemoveItem()
        {
            Assert.IsTrue(inventory.AddItem(i1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);
            Assert.IsTrue(inventory.TakeItem(i1.Name, out Item temp1));
            Assert.AreEqual(inventory.ListAllItems().Count, 0);
            Assert.IsTrue(inventory.AddItem(i1));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);
            Assert.IsFalse(inventory.TakeItem(i2.Name, out Item temp2));
            Assert.AreEqual(inventory.ListAllItems().Count, 1);
        }

        [Test]
        public void Reset()
        {
            Assert.IsTrue(inventory.AddItem(i1));
            Assert.IsTrue(inventory.AddItem(i2));
            Assert.IsTrue(inventory.AddItem(i3));

            inventory.Reset();
            Assert.AreEqual(inventory.ListAllItems().Count, 0);
            Assert.AreEqual(inventory.AvailableSlots, inventory.MaxSlots);
        }
    }
}
