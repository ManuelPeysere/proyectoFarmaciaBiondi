@import url("https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap");
.bannerOfertas {
  display: flex;
  justify-content: center;
}

.bannerAccount {
  width: 70%;
  margin-top: 4%;
  margin-bottom: 1%;
  cursor: pointer;
}

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "Roboto", sans-serif;
}

.main__index {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 90%;
  margin-left: 5%;
}

.carrousel {
  margin-bottom: 3rem;
}

.ofert {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
  width: 85%;
  background-image: linear-gradient(to bottom, #35ca74, #22a884);
  margin-bottom: 5rem;
  border-radius: 30px;
}

#title__offert {
  color: white;
  font-size: 200%;
  font-weight: bold;
  margin-left: 1rem;
  margin-right: 2rem;
}

#description__offert {
  color: white;
  font-size: 120%;
  margin-left: 2rem;
  margin-right: 2rem;
  margin-bottom: 2rem;
}

#link__offert {
  text-decoration: none;
  color: white;
  margin-left: 4rem;
  font-weight: bold;
}

#link__offert:hover {
  font-weight: bold;
  color: white;
}

.div__price {
  display: flex;
  gap: 20px;
}

.img__product {
  width: 10rem;
  margin-top: 1rem;
  margin-bottom: 1rem;
}

.brand {
  font-weight: bold;
  font-size: 160%;
}

.price {
  font-weight: bold;
  font-size: 150%;
}

.brand, .price, .description {
  margin-bottom: 5%;
}

.destacadas {
  display: flex;
  flex-direction: column;
  text-align: center;
}
.destacadas p {
  font-size: 150%;
  color: black;
  font-weight: bold;
  border-bottom: #35ca74 solid 2px;
}

.marcasDestacadas {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
}
.marcasDestacadas img {
  width: 200px;
  height: 200px;
}

.suscription {
  text-align: center;
  padding: 3%;
  background-color: #EFEFEF;
  position: relative;
  width: 100%;
  height: 200px;
}
.suscription img {
  width: 100%;
  height: 100%;
}
.suscription p {
  font-size: 180%;
  font-weight: bold;
  position: absolute;
  top: 25%;
  left: 27%;
}
.suscription input {
  text-align: center;
  width: 25%;
  height: 15%;
  font-size: 110%;
  border: none;
  position: absolute;
  top: 50%;
  left: 32%;
}
.suscription button {
  width: 10%;
  color: white;
  font-weight: bold;
  background-color: #35ca74;
  border: none;
  font-size: 100%;
  padding: 2px;
  position: absolute;
  top: 50%;
  left: 57%;
}

.menu__hamb {
  display: none;
}

.imgDirection img {
  border-radius: 5%;
  margin-bottom: 3%;
  cursor: pointer;
}

.avisos {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  flex-wrap: nowrap;
  cursor: pointer;
  background-color: whitesmoke;
  border-radius: 2%;
  padding: 1%;
}

.group {
  width: 30%;
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
}
.group img {
  width: 30%;
}
.group p {
  font-size: 110%;
}

.group p b:hover {
  color: #35ca74;
}

.access {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  flex-wrap: nowrap;
  margin-bottom: 2%;
  margin-top: 2%;
}
.access img {
  border-radius: 10%;
}

.container {
  margin-bottom: 5%;
}

.buy {
  background-color: whitesmoke;
  border-radius: 10px;
  height: 100%;
  width: 70%;
}

.buy h3 {
  font-size: 30px;
  text-align: center;
  margin-top: 1rem;
  margin-bottom: 1rem;
}

.cupon {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  flex-wrap: nowrap;
  width: 50%;
  background-image: linear-gradient(to bottom, #35ca74, #22a884);
  color: white;
  margin-bottom: 2rem;
  font-size: 150%;
  padding: 1%;
  border-radius: 10px;
  cursor: pointer;
  margin-left: 25%;
}

.cupon span {
  transform: rotate(270deg);
}

.cupon h6 {
  margin-top: 5%;
  font-weight: bold;
}

.buy p {
  margin-bottom: 1rem;
  margin-left: 15%;
}

.button__confirm, .button__continue {
  background-color: #35ca74;
  color: white;
  font-size: 100%;
  font-weight: bold;
  border-radius: 10px;
  padding: 4%;
  border: none;
  cursor: pointer;
  width: 65%;
  margin-top: 3%;
  margin-bottom: 3%;
}

.button__continue {
  background-color: white;
  color: black;
  font-size: 90%;
}

.finish {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.finish p {
  cursor: pointer;
  width: 40%;
}

.finish p:hover {
  color: #22a884;
  font-weight: bold;
  font-size: 16px;
}

.cash {
  display: grid;
  grid-template-columns: 70% 30%;
  grid-template-rows: 33% 33% 33%;
  grid-template-areas: "ele1 ele4" "ele2 ele5" "ele3 ele6";
}

.eleone {
  grid-area: ele1;
}

.eletwo {
  grid-area: ele2;
}

.elethree {
  grid-area: ele3;
  font-weight: bold;
}

.elefour {
  grid-area: ele4;
}

.elefive {
  grid-area: ele5;
}

.elesix {
  grid-area: ele6;
  font-weight: bold;
}

.inputNumber {
  background-color: whitesmoke;
  height: 20%;
  width: 10%;
  border: none;
  font-size: 20px;
  display: grid;
  grid-area: ele4;
  margin-top: 10%;
}

.mediosPago {
  display: flex;
  justify-content: center;
  padding: 3%;
}

.ofertasPago {
  width: 90%;
  cursor: pointer;
}

.select__one {
  display: flex;
  width: 100%;
}

.select__two {
  display: flex;
  width: 100%;
}

.col {
  margin-left: 5%;
}

.form a {
  text-decoration: none;
}

.form a:hover {
  font-size: 120%;
}

.form {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: 30px;
  margin-top: 3rem;
  margin-bottom: 3rem;
  border: #22a884 solid 2px;
  width: 50%;
  border-radius: 10px;
  background-image: whitesmoke;
}
.form h4 {
  font-size: 180%;
  color: #22a884;
  font-weight: bold;
  text-align: center;
}
.form h3 {
  font-size: 120%;
  color: #22a884;
  font-weight: bold;
  text-align: center;
}
.form p {
  font-size: 110%;
  color: #35ca74;
  font-weight: bold;
  text-align: center;
  cursor: pointer;
}

.form__input {
  padding: 100%;
  margin-bottom: 3rem;
  background-color: #35ca74;
  color: white;
  font-size: 18px;
  font-weight: bold;
  border-radius: 10px;
  padding: 10px;
  border: none;
  cursor: pointer;
  width: 100px;
}

.cliente {
  font-size: 28px;
  font-weight: bold;
}

.faq__style {
  width: 80%;
  margin-left: 10%;
  margin-right: 10%;
  margin-top: 5%;
  margin-bottom: 5%;
}

.faq__style iframe {
  width: 100%;
  padding: 2rem;
}

.faq__ref {
  text-decoration: none;
}

.rrss__link {
  text-decoration: none;
}

.rrss__url {
  display: flex;
  flex-direction: column;
}

.navProducts {
  margin-top: 3%;
  border-top: whitesmoke solid 5px;
  width: 80%;
  margin-left: 10%;
}

.navProducts a {
  color: #333;
  font-size: 120%;
}

.navProducts a:hover {
  color: white;
  font-weight: 1000;
  background-color: #35ca74;
  border-radius: 10%;
}

.navProducts ul {
  gap: 5%;
}

.main {
  display: flex;
  justify-content: center;
}

.section__products {
  display: flex;
  justify-content: center;
  gap: 80px;
  width: 80%;
  margin-top: 3rem;
  margin-bottom: 3rem;
  flex-wrap: wrap;
}

.product {
  display: flex;
  flex-direction: column;
  width: 250px;
  margin-top: 1rem;
  margin-bottom: 1rem;
  margin-right: 1rem;
  border: whitesmoke 2px solid;
  padding: 10px;
  background-color: white;
  align-items: center;
  border-radius: 10px;
  cursor: pointer;
}

.product:hover {
  box-shadow: 11px 15px 5px 0px rgba(0, 0, 0, 0.16);
}

.button {
  background-color: #35ca74;
  color: white;
  font-size: 100%;
  font-weight: bold;
  border-radius: 10px;
  padding: 10px;
  border: none;
  cursor: pointer;
  margin-left: 3rem;
}

.section__filter {
  display: flex;
  flex-direction: column;
  width: 20rem;
  margin-top: 4rem;
  flex-wrap: nowrap;
  order: -1;
  background-color: whitesmoke;
  margin-bottom: 3rem;
  gap: 10px;
  height: 100%;
  margin-left: 3rem;
}

.section__filter h5 {
  font-size: 25px;
  margin-top: 1rem;
  margin-bottom: 1rem;
  margin-left: 1rem;
  color: #22a884;
  font-weight: bold;
}

.section__filter label {
  margin-left: 1rem;
}

.section__filter label:hover {
  cursor: pointer;
  color: #22a884;
  font-weight: bold;
}

.section__filter button {
  padding: 10px;
  align-self: center;
  margin-top: 1rem;
  margin-bottom: 2rem;
  cursor: pointer;
  border-radius: 10px;
  background-color: #35ca74;
  color: white;
  font-size: 100%;
  font-weight: bold;
  border: none;
}

.range {
  display: flex;
  flex-direction: row;
  flex-wrap: nowrap;
  align-self: center;
  text-align: center;
}

.range input {
  width: 30%;
  height: 100px;
}

.bannerProducts {
  width: 100%;
  margin-top: 1%;
}

.encabezado {
  display: flex;
  flex-direction: row;
  background-color: whitesmoke;
  padding: 2%;
  justify-content: space-between;
  margin-top: 2%;
  width: 80%;
  margin-left: 10%;
  border-radius: 10px;
}
.encabezado h6 {
  font-size: 120%;
  color: #35ca74;
  font-weight: bold;
}

.Order {
  margin-right: 10%;
}
.Order button {
  font-size: 100%;
}

.header {
  height: 100px;
  margin-bottom: 3rem;
}

.header__container {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: center;
  background-color: whitesmoke;
  position: fixed;
  z-index: 100;
  width: 100%;
}

.header__containerb {
  background-color: whitesmoke;
  position: fixed;
  z-index: 100;
  width: 100%;
}

.logo__farm {
  width: 3rem;
  margin-left: 100%;
  margin-right: 100%;
  margin-top: 1rem;
  margin-bottom: 1rem;
}

.logo__farma {
  width: 3rem;
}

.navbar__list {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  list-style-type: none;
  font-weight: bold;
  gap: 5%;
  padding: 1rem;
  height: 70px;
  width: 100%;
  margin-top: 80px;
  position: fixed;
  z-index: 100;
  background-color: white;
}

.navbar__hijo {
  color: #333;
  font-size: 20px;
}

.nav__link:hover {
  color: #22a884;
}

.nav__link {
  color: #333;
  text-decoration: none;
  display: inline-block;
  vertical-align: middle;
  -webkit-transform: perspective(1px) translateZ(0);
}

.nav__link:before {
  content: "";
  position: absolute;
  z-index: -1;
  left: 0;
  right: 100%;
  bottom: 0;
  background: #22a884;
  height: 2px;
  -webkit-transition-property: right;
  transition-property: right;
  -webkit-transition-duration: 0.3s;
  transition-duration: 0.3s;
  -webkit-transition-timing-function: ease-out;
  transition-timing-function: ease-out;
}

.nav__link:hover:before, .nav__link:focus:before, .nav__link:active:before {
  right: 0;
}

.busqueda__input {
  height: 40px;
  width: 40%;
  border-radius: 10px;
  margin-top: 10px;
  margin-left: 10%;
  border: none;
  text-align: center;
}

.jam__header {
  text-decoration: none;
  font-size: 18px;
  color: #333;
  font-weight: bold;
}

.jam__header:hover {
  color: #22a884;
  font-weight: bold;
  font-size: 20px;
}

.icons {
  margin-left: 5%;
  margin-right: 5%;
}

.footer {
  display: flex;
  background-color: whitesmoke;
  padding: 5rem;
  justify-content: center;
  width: 100%;
}

.footer__style {
  color: #333;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
  gap: 80px;
}

.footer__style h3 {
  font-size: 120%;
  font-weight: 1000;
}

.footer__style p {
  font-size: 100%;
  font-weight: 700;
}

.footer__name {
  align-items: flex-end;
}

.footer__style a {
  color: #333;
  font-weight: 700;
}

.footer__style a:hover {
  color: #22a884;
  font-weight: bold;
}

@media screen and (max-width: 600px) {
  .navbar__list {
    display: none;
  }

  .header__container {
    width: 100%;
    height: 100px;
    display: flex;
    justify-content: space-around;
  }

  .icons {
    display: none;
  }

  .menu__hamb {
    display: flex;
    transform: scale(3);
  }

  .busqueda__input {
    height: 40px;
    width: 50%;
    font-size: 15px;
    font-weight: bold;
  }

  .logo__farm {
    width: 80px;
    margin-left: 10%;
    margin-top: 1rem;
    margin-bottom: 1rem;
  }

  .carrousel__img {
    margin-top: 2rem;
    width: 80%;
  }

  .access {
    display: flex;
    flex-direction: row;
    width: 100%;
  }

  .access img {
    width: 180px;
    margin-bottom: 10px;
    margin-right: 10px;
    margin-right: 10px;
    margin-left: 0;
    flex-direction: row;
    flex-wrap: wrap;
  }

  .ofert {
    width: 80%;
    height: 120%;
    display: flex;
    flex-direction: wrap;
    flex-wrap: wrap;
  }

  #title__offert {
    font-size: 25px;
    margin-left: 40px;
  }

  #description__offert {
    font-size: 20px;
    margin-bottom: 15px;
  }

  .ofert article {
    width: 43%;
    margin-left: 8px;
  }

  .img__product {
    width: 5rem;
    margin-top: 1rem;
    margin-bottom: 1rem;
  }

  .div__price p del {
    font-size: 12px;
  }

  .brand {
    font-weight: bold;
    font-size: 15px;
  }

  .price {
    font-weight: bold;
    font-size: 16px;
  }

  .description {
    font-size: 12px;
  }

  .brand, .price, .description {
    margin-bottom: 5px;
  }

  .button {
    background-color: #22a884;
    color: white;
    font-size: 12px;
    font-weight: bold;
    border-radius: 10px;
    padding: 8px;
    border: none;
    cursor: pointer;
    margin-left: 15%;
  }

  .product button {
    margin-left: 25%;
  }

  .footer__style {
    gap: 20px;
  }

  .section__products {
    gap: 10px;
    width: 60%;
  }

  .section__filter {
    flex-wrap: nowrap;
    height: 100%;
    margin-right: 1rem;
    width: 30%;
  }

  .section__filter button {
    margin-top: 1rem;
    margin-bottom: 2rem;
    font-size: 12px;
  }

  .section__filter h5 {
    font-size: 18px;
  }

  .section__filter label {
    font-size: 12px;
    margin-right: 2rem;
  }

  .cash {
    margin-right: 8%;
  }

  .form {
    width: 80%;
  }

  .headerNewP {
    display: flex;
    flex-direction: row;
    flex-wrap: nowrap;
  }

  .suscription {
    display: none;
  }

  .bannerProducts {
    width: 80%;
    margin-left: 10%;
  }

  .encabezado {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-bottom: none;
  }

  .navProducts {
    display: none;
  }

  .avisos {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
    cursor: pointer;
    background-color: whitesmoke;
    border-radius: 2%;
    padding: 1%;
  }

  .access {
    flex-direction: row;
    justify-content: space-between;
  }

  .group {
    width: 40%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  .group p {
    font-size: 110%;
  }

  .avisos {
    width: 100%;
  }

  .imgDirection {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    justify-content: center;
    width: 80%;
  }
  .imgDirection img {
    width: 80%;
  }

  .marcasDestacadas {
    justify-content: center;
  }
  .marcasDestacadas img {
    width: 100px;
    height: 100px;
  }
}

/*# sourceMappingURL=style.cs.map */
