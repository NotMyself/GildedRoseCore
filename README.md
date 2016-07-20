# Gilded Rose Refactoring Kata for .NET Core

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense type named Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that we can begin selling a new category of items. First an introduction to our system:


- All items have a SellIn value which denotes the number of days we have to sell the item
- All items have a Quality value which denotes how valuable the item is
- At the end of each day our system lowers both values for every item


Pretty simple, right? Well this is where it gets interesting:

- Once the sell by date has passed, Quality degrades twice as fast
- The Quality of an item is never negative
- "Aged Brie" actually increases in Quality the older it gets
- The Quality of an item is never more than 50
- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
- "Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything still works correctly. However, do not alter the Item class or Items property as those belong to the goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

## Getting Started

1. Install [.NET Core SDK 1.0](https://www.microsoft.com/net/core). 
2. Install [Visual Studio Code](https://code.visualstudio.com/), the [Insiders Edition](https://code.visualstudio.com/insiders) is highly recommended.
3. Clone the repository: `git clone https://github.com/NotMyself/GildedRoseCore.git`.
4. Restore packages: `./script/restore`.
5. Run Console Application: `./script/run`.
6. Run Unit Tests: `./script/test`.

If you see output similar to the following screenshot, you are ready to start refactoring. **Note:** For windows users ensure you download the [SDK](https://go.microsoft.com/fwlink/?LinkID=809122), it is not the first link on the page.


### Bash

![bash good restore, run, test output](/images/bash_restore_run_test.png?raw=true "bash good restore, run, test output")

### PowerShell

![powershell good restore, run, test output](/images/powershell_restore_run_test.png?raw=true "powershell good restore, run, test output")

## Debugging in VSCode

The workspace comes preconfigured to debug the console application in VSCode. Simply, click the debug icon and then the play icon.

![vscode debug console](/images/vscode_debug_console.png?raw=true "vscode debug console")

To debug a unit test, locate the `debug test` link in the codelens display.

![vscode debug test](/images/vscode_debug_test.png?raw=true "vscode debug test")

## Who, What, Why?

Who: [@TerryHughes](https://twitter.com/TerryHughes), [@NotMyself](https://twitter.com/NotMyself)

What & Why: [Refactor This: The Gilded Rose Kata](http://iamnotmyself.com/2016/07/20/refactor-this-the-gilded-rose-kata-for-net-core/)

## License

MIT

## Suggested attribution

This work is by [@TerryHughes](https://twitter.com/TerryHughes), [@NotMyself](https://twitter.com/NotMyself)

The repository can be found at [https://github.com/NotMyself/GildedRoseCore](https://github.com/NotMyself/GildedRoseCore)