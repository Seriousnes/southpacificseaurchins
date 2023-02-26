<script setup lang="ts">
import { ref, onMounted } from 'vue';
import ContentLayout from '@/components/ContentLayout.vue';
import ProductDetails from '@/components/ProductDetails.vue';
import type ProductDetailsModel from "@/models/ProductDetails";

let data = ref<ProductDetailsModel[]>();

onMounted(async () => {
    let request: Response;
    
    request = await fetch("../src/assets/products.json");
    data.value = await request.json();
})
</script>


<template>
    <ContentLayout>
        <template #header>Products</template>
        <template #page-content>            
            <div v-for="(item, index) in data" v-bind:key="index" class="py-3">
                <ProductDetails :index=index v-bind:model=item></ProductDetails>
            </div>
        </template>
    </ContentLayout>
</template>