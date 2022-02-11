const cross = document.querySelector("#cross");

const menu = document.querySelector("#menu");

const bars = document.querySelector("#bars")

cross.addEventListener("click", () => {
    menu.classList.toggle("hideMenu");
    cross.classList.toggle("hideCross");
})

bars.addEventListener("click", () => {
    menu.classList.remove("hideMenu");
    cross.classList.remove("hideCross");
})