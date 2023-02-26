<script setup lang="ts">
import { ref, onMounted } from 'vue';
import ContentLayout from '@/components/ContentLayout.vue';
import ProductDetails from '@/components/ProductDetails.vue';
import type ProductDetailsModel from "@/models/ProductDetails";

let data = ref<ProductDetailsModel[]>();

onMounted(async () => {
    let request = await fetch("../src/assets/turboshell.json");
    data.value = await request.json();
})
</script>

<template>
    <ContentLayout>
        <template #header>Turban Shell</template>
        <template #blurb>
            Turban shells are a group of molluscs known as gastropods. The have a large spiral shell and a hard door
            they can close to protect themselves, called an operculum. The most well known gastropods are abalone.
            Whilst turbos are not abalone, they are similar in taste and live in the same environments.
        </template>
        <template #page-content>
            <div v-for="(item, index) in data" v-bind:key="index" class="py-3">
                <ProductDetails :index=index v-bind:model=item></ProductDetails>
            </div>
        </template>
    </ContentLayout>
</template>