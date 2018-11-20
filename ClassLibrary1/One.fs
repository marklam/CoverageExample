namespace ClassLibrary1

module One =
    // inline so we can work with int or float
    let inline smallestFirst x y =
        if (abs x) < (abs y)
        then x,y
        else y,x


