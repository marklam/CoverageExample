namespace ClassLibrary2

open ClassLibrary1.One

module Two =
    // inline so we can work with int or float
    let inline thing x y z =
        if x < y
        then smallestFirst x z
        else smallestFirst y z

