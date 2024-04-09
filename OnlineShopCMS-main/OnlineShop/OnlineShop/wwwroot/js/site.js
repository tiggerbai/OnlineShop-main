// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script>
  var swiper = new Swiper('.swiper-container__mall-index-catelist', {
    slidesPerView: 3,
  spaceBetween: 30,
  pagination: {
    el: '.swiper-pagination',
  clickable: true,
            },
  navigation: {
    nextEl: '.swiper-button-next',
  prevEl: '.swiper-button-prev',
            },
        });
</script>
