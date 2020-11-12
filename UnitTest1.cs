// using System.Linq;
// using Xunit;

// namespace C__Project
// {
// public class DndCharacterTest
// {
//     [Fact(Skip = "Remove to run test")]
//     public void Random_ability_is_within_range()
//     {
//         for (var i = 0; i < 10; i++)
//         {
//             Assert.InRange(Character.Ability(), 3, 18);
//         }
//     }

//     [Fact(Skip = "Remove to run test")]
//     public void Random_character_is_valid()
//     {
//         for (var i = 0; i < 10; i++)
//         {
//             var sut = Character.Gen();
//             Assert.InRange(sut.Str, 3, 18);
//             Assert.InRange(sut.Dex, 3, 18);
//             Assert.InRange(sut.Con, 3, 18);
//             Assert.InRange(sut.Int, 3, 18);
//             Assert.InRange(sut.Wis, 3, 18);
//             Assert.InRange(sut.Cha, 3, 18);
//             Assert.Equal(sut.Hp, 10 + Character.Modifier(sut.Con));
//         }
//     }

//     [Fact(Skip = "Remove to run test")]
//     public void Each_ability_is_only_calculated_once()
//     {
//         for (var i = 0; i < 10; i++)
//         {
//             var sut = Character.Gen();
//             Assert.Equal(sut.Str, sut.Str);
//             Assert.Equal(sut.Dex, sut.Dex);
//             Assert.Equal(sut.Con, sut.Con);
//             Assert.Equal(sut.Int, sut.Int);
//             Assert.Equal(sut.Wis, sut.Wis);
//             Assert.Equal(sut.Cha, sut.Cha);
//         }
//     }
// }

// }