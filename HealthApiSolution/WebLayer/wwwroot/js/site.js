// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    window.addEventListener('scroll', () => {
        document
            .querySelector('nav')
            .classList.toggle('window-scroll', window.scrollY > 100);
    });

    window.addEventListener('click', () => {
        document.querySelectorAll('.faq').classList.toggle('open');
    });
    const allFaqs = document.querySelectorAll('.faq');
    allFaqs.forEach((i) => {
        i.addEventListener('click', () => {
            i.classList.toggle('open');

            const icon = i.querySelector('.faq__icon i');
            if (icon.classList.contains('fa-caret-up'))
                icon.classList.replace('fa-caret-up', 'fa-caret-down');
            else icon.classList.replace('fa-caret-down', 'fa-caret-up');
        });
    });

var swiper = new Swiper('.mySwiper', {
    autoplay: {
        delay: 3000
    },
    slidesPerView: 1.5,
    spaceBetween: 30,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    breakpoints: {
        600: {
            slidesPerView: 2,
        }
    }
    });

    const menu = document.querySelector('.nav__menu');
    const openMenu = document.querySelector('#open-menu');
    const closeMenu = document.querySelector('#close-menu');

    openMenu.addEventListener('click', () => {
        menu.style.display = 'flex';
        closeMenu.style.display = 'inline-block';
        openMenu.style.display = 'none';
    });
    closeMenu.addEventListener('click', () => {
        menu.style.display = 'none';
        closeMenu.style.display = 'none';
        openMenu.style.display = 'inline-block';
    });

