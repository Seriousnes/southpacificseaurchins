<script setup lang="ts">
import router from "../router";
import type ProductDetailsModel from "@/models/ProductDetails";

const props = defineProps<{
    index: number,
    model: ProductDetailsModel,
}>();
</script>


<template>
    <div class="row">
        <div class="col-lg-3 col-md-5 col-sm-12">
            <img class="product-image me-3 ps-0" :src="`../src/assets/images/products/${model.imageUrl}`" />
        </div>
        <div class="col-lg-9 col-md-7 col-sm-12">
            <h3 class="pb-2">{{ model.productName }}</h3>
            <p class="justify-text" v-html="model.productDescription"></p>
            <div>
                <p class="fw-bold text-uppercase mb-0">Availability</p>
                <p class="mb-0">{{ model.availability }}</p>
            </div>
        </div>
    </div>
</template>

<style scoped>
.product-image {
    /* border-radius: 50%; */
    border-radius: 5px;
    border-width: 2px;
    border-color: black;
    border-style: solid;
    overflow: hidden;
    height: 270px;
    width: 270px;
}

img {
    display: inline;
    margin: 0 auto;
    height: 100%;
    width: auto;
}
</style>