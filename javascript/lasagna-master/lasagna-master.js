/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus (time=undefined) {
    if (time == undefined)
        return 'You forgot to set the timer.';
    else if (time == 0) 
        return 'Lasagna is done.';
    else 
        return ('Not done, please wait.');
}

export function preparationTime (layers=[], timePerLayer=2) {
    return layers.length * timePerLayer;
}

export function quantities (layers=[]) {
    var noodles = 0;
    var sauce = 0;

    for (var layer of layers) {
        if (layer == "noodles")
            noodles += 50;
        else if (layer == "sauce")
            sauce += 0.2;
    }

    return { noodles: noodles, sauce: sauce };
}

export function addSecretIngredient(friendsList=[], myList=[]) {
    myList.push(friendsList[friendsList.length-1]);
}

export function scaleRecipe (recipe={}, portionsNeeded=0) {
    var scale = portionsNeeded / 2;
    var newRecipe = {...recipe};

    for (var key in newRecipe) {
        newRecipe[key] *= scale;
    }

    return newRecipe;
}