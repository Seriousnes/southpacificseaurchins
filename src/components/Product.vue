<script setup lang="ts">
import router from "../router";

const props = defineProps<{
    productName: string
    imageUrl: string,
    productUrl: string,
    showButton: boolean,
}>();

function handleClick(event: any) {
    router.push({ name: props.productUrl });
}
</script>


<template>
    <div class="d-flex flex-row">
        <div class="d-flex">
            <img class="product-image me-3 ps-0" v-bind:src=imageUrl />
        </div>
        <div class="d-flex flex-column">
            <h2>{{ productName }}</h2>
            <p class="justify-text">
               <slot name="productDescription"></slot>
            </p>
            <div v-if="showButton" class="d-flex flex-row justify-content-end">
                <button class="btn btn-primary" @click="handleClick">
                    See all {{ productName }}
                </button>
            </div>
        </div>
    </div>
</template>

<style scoped>
.product-image {
    border-radius: 50%;
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