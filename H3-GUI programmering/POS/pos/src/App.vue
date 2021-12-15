<template>
  <div class="wrapper">
    <div class="one">
      <h2 class="item">3 Æbleskiver</h2>
      <p class="price">15,-</p>
    </div>
    <div class="two">
      <h2 class="item">5 Æbleskiver</h2>
      <p class="price">20,-</p>
    </div>
    <div class="three">
      <h2 class="item">Gløgg</h2>
      <p class="price">5,-</p>
    </div>
    <div class="four">
      <h2 class="item">Kaffe</h2>
      <p class="price">5,-</p>
    </div>
    <div class="five">
      <h2 class="item">Cola 33 cl</h2>
      <p class="price">10,-</p>
    </div>
    <div class="six">
      <h2 class="item">Risengrød</h2>
      <p class="price">15,-</p>
    </div>
    <div class="seven">
      <h2 class="item">Bestik</h2>
      <p class="price">5,-</p>
    </div>
    <div class="eight">
      <h2 class="item">Julegodter</h2>
      <p class="price">25,-</p>
    </div>
    <div class="nine">
      <h2 class="item">Brændte mandler</h2>
      <p class="price-nine">25,-</p>
    </div>
    <div class="ten">
      <h2 class="item">Frugt</h2>
      <p class="price">5,-</p>
    </div>
    <div class="elleven">
      <h2 class="item">Appelsin 33 cl</h2>
      <p class="price">10,-</p>
    </div>
    <div class="twelve">
      <h2 class="item">Simone</h2>
      <p class="price">100,-</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "App",
  components: {},
};
</script>

<style>
body{
  background: rgb(68,68,68);
}
h2 {
  color: white;
}
p {
  color: white;
}
.wrapper {
  display: grid;
  grid-template-columns: 200px 200px 200px 200px 200px;
  grid-auto-rows: 150px;
  
}
.price{
  margin-left: 140px;
  margin-top: 50px;
}
.price-nine{
  margin-left: 140px;
  margin-top: 23px;
}
.one {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(255,68,68) 0%,
    rgb(255,0,0) 35%,
    rgb(238,0,0) 100%
  );
}
.two {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(255,68,68) 0%,
    rgb(255,0,0) 35%,
    rgb(238,0,0) 100%
  );
}
.three {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(68,218,68) 0%,
    rgb(0,204,0) 35%,
    rgb(0,190,0) 100%
  );
}
.four {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(68,218,68) 0%,
    rgb(0,204,0) 35%,
    rgb(0,190,0) 100%
  );
}
.five {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(68,68,255) 0%,
    rgb(0,0,255) 35%,
    rgb(0,0,238) 100%
  );
}
.six {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(255,68,68) 0%,
    rgb(255,0,0) 35%,
    rgb(238,0,0) 100%
  );
}
.seven {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(0,204,204) 0%,
    rgb(0,170,170) 35%,
    rgb(0,159,159) 100%
  );
}
.eight {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(193,193,68) 0%,
    rgb(170,170,0) 35%,
    rgb(159,159,0) 100%
  );
}
.nine {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(193,193,68) 0%,
    rgb(170,170,0) 35%,
    rgb(159,159,0) 100%
  );
}
.ten {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(255,68,68) 0%,
    rgb(255,0,0) 35%,
    rgb(238,0,0) 100%
  );
}
.elleven {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgb(68,68,255) 0%,
    rgb(0,0,255) 35%,
    rgb(0,0,238) 100%
  );
}
.twelve {
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: rgb(2, 0, 36);
  background: linear-gradient(
    rgba(2, 0, 36, 1) 0%,
    rgba(9, 9, 121, 1) 35%,
    rgba(0, 212, 255, 1) 100%
  );
}
</style>
