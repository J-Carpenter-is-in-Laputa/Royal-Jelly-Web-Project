// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.querySelectorAll('.parallax-card').forEach(card => {
    // for better performance 
    const img = new Image();
    img.src = card.style.backgroundImage.replace(/url\(['"]?(.*?)['"]?\)/, '$1');

    // for click 
    card.addEventListener('click', function () {
        if (this.getAttribute('onclick')) return;
        const link = this.querySelector('a');
        if (link) link.click();
    });
});