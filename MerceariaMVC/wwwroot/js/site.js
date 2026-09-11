document.addEventListener("DOMContentLoaded", () => {

    const pulseButton =
        document.getElementById("themePulse");

    const quickAction =
        document.getElementById("quickAction");


    /*
     * EFEITO DE BRILHO
     */

    pulseButton?.addEventListener("click", () => {

        document.body.classList.remove("flash-pink");

        void document.body.offsetWidth;

        document.body.classList.add("flash-pink");

    });


    /*
     * BOTÃO NOVA MOVIMENTAÇÃO
     */

    quickAction?.addEventListener("click", () => {

        quickAction.innerHTML =
            "<span>✓</span> Movimento iniciado";


        setTimeout(() => {

            quickAction.innerHTML =
                "<span>＋</span> Nova movimentação";

        }, 1500);

    });


    /*
     * EFEITO NOS CARDS
     */

    const cards =
        document.querySelectorAll(".stat-card");


    cards.forEach((card) => {

        card.addEventListener("mousemove", (event) => {

            const rect =
                card.getBoundingClientRect();

            const x =
                event.clientX - rect.left;

            const y =
                event.clientY - rect.top;


            const rotateX =
                ((y / rect.height) - 0.5) * -4;

            const rotateY =
                ((x / rect.width) - 0.5) * 4;


            card.style.transform =
                `perspective(700px)
                 rotateX(${rotateX}deg)
                 rotateY(${rotateY}deg)
                 translateY(-5px)`;

        });


        card.addEventListener("mouseleave", () => {

            card.style.transform = "";

        });

    });

});