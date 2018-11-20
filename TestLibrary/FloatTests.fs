namespace TestLibrary

open NUnit.Framework
open ClassLibrary1
open ClassLibrary2

module FloatTests =
    [<Test>]
    let ``already sorted items come back still sorted`` () =
        let expected = (1., 2.)
        let actual = One.smallestFirst 1. 2.
        Assert.AreEqual(expected, actual)

    [<Test>]
    let ``out of order come back reversed`` () =
        let expected = (6., 7.)
        let actual = One.smallestFirst 7. 6.
        Assert.AreEqual(expected, actual)

    [<Test>]
    let ``if the first is smallest we get first and third`` () =
        let expected = (1., 3.)
        let actual = Two.thing 1. 2. 3.
        Assert.AreEqual(expected, actual)

    [<Test>]
    let ``if the second is smallest we get second and third`` () =
        let expected = (6., 8.)
        let actual = Two.thing 7. 6. 8.
        Assert.AreEqual(expected, actual)

    [<Test>]
    let ``if the third is smallest we get third and then smallest of first and second`` () =
        let expected = (5., 6.)
        let actual = Two.thing 7. 6. 5.
        Assert.AreEqual(expected, actual)

    [<Test>]
    let ``if the third is smallest we get third and then smallest of first and second (2)`` () =
        let expected = (5., 6.)
        let actual = Two.thing 6. 7. 5.
        Assert.AreEqual(expected, actual)
