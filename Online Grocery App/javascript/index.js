const sliderImage = document.querySelector("#slider img");

const leftArrow = document.querySelector(".leftArrow");

const rightArrow = document.querySelector(".rightArrow");

const srcSet = document.querySelector("#slider source");

let imageNumber = 1;

leftArrow.addEventListener("click", () => {
    imageNumber--;
    if (imageNumber < 1) {
        imageNumber = 5;
        sliderImage.src = `./Images/slider${imageNumber}.jpg`;
        srcSet.srcset = `./Images/sliderSmall${imageNumber}.jpg`;
    }

    else {

        sliderImage.src = `./Images/slider${imageNumber}.jpg`;

        srcSet.srcset = `./Images/sliderSmall${imageNumber}.jpg`;
    }

})

rightArrow.addEventListener("click", nextImage);

function nextImage() {
    imageNumber++;

    if (imageNumber > 5) {
        imageNumber = 1;
        sliderImage.src = `./Images/slider${imageNumber}.jpg`;

        srcSet.srcset = `./Images/sliderSmall${imageNumber}.jpg`;

    } else {
        sliderImage.src = `./Images/slider${imageNumber}.jpg`;

        srcSet.srcset = `./Images/sliderSmall${imageNumber}.jpg`;
    }
}

setInterval(nextImage, 4000);